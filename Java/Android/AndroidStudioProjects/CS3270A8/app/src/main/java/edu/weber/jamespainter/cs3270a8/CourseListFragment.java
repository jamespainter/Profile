package edu.weber.jamespainter.cs3270a8;


import android.database.Cursor;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v4.app.ListFragment;
import android.support.v4.widget.CursorAdapter;
import android.support.v4.widget.SimpleCursorAdapter;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;


/**
 * A simple {@link Fragment} subclass.
 */
public class CourseListFragment extends ListFragment{

    protected ArrayAdapter<String> courseID;
    protected ArrayAdapter<String> courseName;
    protected ArrayAdapter<String> courseCode;
    protected ArrayAdapter<String> courseStartAt;
    protected ArrayAdapter<String> courseEndAt;
    protected ArrayAdapter<String> assignmentAdapter;

    public CourseListFragment() {
        // Required empty public constructor
    }

    private String[] items = new String[] {"one", "two", "three"};
    private String[] digits = new String[]{"1", "2", "3"};


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        assignmentAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_selectable_list_item);

        new getAllCourses().execute("");
        return super.onCreateView(inflater, container, savedInstanceState);
    }



    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);

        AdapterView.OnItemLongClickListener listener = new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> arg0, View arg1, int position, long id) {
                Toast.makeText(getActivity().getBaseContext(), "Going to Course Assignments", Toast.LENGTH_SHORT).show();
                DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1);
                Cursor cursor = dbHelper.getCourseID(id);
                String ID="";
                cursor.moveToFirst();
                ID = cursor.getString(cursor.getColumnIndex("ID"));
                MainActivity ma = (MainActivity) getActivity();
                if(ma != null){

                    ma.getAssignmentList(ID);
                }
                return true;
            }
        };

        getListView().setOnItemLongClickListener(listener);
    }

    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        super.onListItemClick(l, v, position, id);
        Log.d("test", "ListView position:" + position +" _id:" + id);
        MainActivity ma = (MainActivity) getActivity();
        if(ma != null) {
            ma.populateCourse(id);
        }

    }
    //AsyncTask is a way to do multi-threading. <String/Activity is what we are passing to the do in
//background Integer is on progress, Cursor is the same of the onPostExecute
    public class getAllCourses extends AsyncTask<String, Integer, Cursor>
    {


        @Override
        protected Cursor doInBackground(String... params) {

            DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1);
            Cursor cursor = dbHelper.getAllCourse();
            return cursor;

        }

        @Override
        protected void onPostExecute(Cursor cursor) {
            super.onPostExecute(cursor);

            String[] columns = new String[] {"Name","Code"};
            int[] views = new int[] {android.R.id.text1};
            SimpleCursorAdapter adapter = new SimpleCursorAdapter(getActivity(), android.R.layout.simple_list_item_1,
                    cursor, columns, views, CursorAdapter.FLAG_REGISTER_CONTENT_OBSERVER);
            setListAdapter(adapter);

        }
    }




    public class getCanvasCourses extends AsyncTask<String, Integer, String> {

        // Create a separate public final class to hold your token
        String AUTH_TOKEN = Authorization.AUTH_TOKEN;

        String rawJson = "";

        @Override
        protected String doInBackground(String... params) {
            Log.d("test", "In AsyncTask getCanvasCourses");
            try{
                URL url = new URL("https://weber.instructure.com/api/v1/courses");
                HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
                conn.setRequestMethod("GET");
                conn.setRequestProperty("Authorization", "Bearer " + AUTH_TOKEN);
                int status = conn.getResponseCode();
                switch (status)
                {
                    case 200: //200 or 201 indicate success
                    case 201:
                        BufferedReader br =
                                new BufferedReader(new InputStreamReader(conn.getInputStream()));
                        rawJson = br.readLine();
                        Log.d("Test","raw Json String Length = " + rawJson.length());
                        Log.d("Test", "raw Json first 256 chars: "+ rawJson.substring(0, 256));
                        Log.d("Test", "raw Json first 256 chars: "+ rawJson.substring(rawJson.length()));

                }


            }
            catch(MalformedURLException e)
            {
                Log.d("Test", e.getMessage());
                System.out.println(e.toString());
            }
            catch(IOException e){
                Log.d("Test", e.getMessage());
            }
            return rawJson;
        }

        @Override
        protected void onPostExecute(String result){

            super.onPostExecute(result);
            DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1 );
//            courseID.clear();
//            courseName.clear();
//            courseCode.clear();
//            courseStartAt.clear();
//            courseEndAt.clear();
            try {
                CanvasObjects.Course[] courses = jsonParse(result);
                for (CanvasObjects.Course course : courses){


                    long rowID = dbHelper.insertCourse(

                            course.id.toString(),
                            course.name.toString(),
                            course.course_code.toString(),
                            course.start_at.toString(),
                            course.end_at.toString()
                    );
//                    courseID.add(course.id);
//                    courseName.add(course.name);
//                    courseCode.add(course.course_code);
//
                 }


            }catch (Exception e){

                Log.d("Test", e.getMessage());
            }

            MainActivity ma = (MainActivity) getActivity();
            if(ma != null)
            {
                ma.reloadCourseListFragment();
            }
        }

        private CanvasObjects.Course[] jsonParse(String rawJson)
        {
            CanvasObjects.Course[] courses = null;
            GsonBuilder gsonb = new GsonBuilder();
            Gson gson = gsonb.create();

            try{
                courses = gson.fromJson(rawJson, CanvasObjects.Course[].class);
                Log.d("Test","Number of courses returned is: " + courses.length);
                Log.d("Test", "First Course returned is: " + courses[0].name);

            }catch(Exception e)
            {
                Log.d("test", e.getMessage());
            }
            return courses;

        }



    }

    public void importCanvasCourses()
    {
        new getCanvasCourses().execute("");
    }





}
