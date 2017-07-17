package edu.weber.jamespainter.cs3270a8;


import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageButton;
import android.widget.ListView;
import android.widget.TextView;

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
public class AssignmentFragment extends Fragment {

    protected TextView tv_list_assignments_course;
    protected ListView lv_assignments;
    protected ArrayAdapter<String> assignmentAdapter;
    protected int courseID;
    private static String assignment_course_id ;
    public AssignmentFragment(){



    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstancesState)
    {
        View rootview = inflater.inflate(R.layout.fragment_assignment, container, false);

        tv_list_assignments_course = (TextView) rootview.findViewById(R.id.tv_list_assignments_course);
        lv_assignments = (ListView) rootview.findViewById(R.id.lv_assignments);


        //Simple binding to the ListView
        assignmentAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_selectable_list_item);


        return rootview;
    }

    public class getCanvasCourseAssignments extends AsyncTask<String, Integer, String> {

        // Create a separate public final class to hold your token
        String AUTH_TOKEN = Authorization.AUTH_TOKEN;

        String rawJson = "";

        @Override
        protected String doInBackground(String... params) {
            Log.d("test", "In AsyncTask getCanvasCourses");
            try{
                Log.d("test", assignment_course_id);
                //URL url = new URL("https://weber.instructure.com/api/v1/courses/388887/assignments");
                URL url = new URL("https://weber.instructure.com/api/v1/courses/"+assignment_course_id+"/assignments");
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

            assignmentAdapter.clear();
            try {
                CanvasObjects.Assignment[] assignments = jsonParse(rawJson);
                for (CanvasObjects.Assignment assignment : assignments){

                    assignmentAdapter.add(assignment.name);

                }


            }catch (Exception e){

                Log.d("Test", e.getMessage());
            }

        }

        private CanvasObjects.Assignment[] jsonParse(String rawJson)
        {
            CanvasObjects.Assignment[] assignments = null;
            GsonBuilder gsonb = new GsonBuilder();
            Gson gson = gsonb.create();

            try{
                assignments = gson.fromJson(rawJson, CanvasObjects.Assignment[].class);
                Log.d("Test","Number of courses returned is: " + assignments.length);
                Log.d("Test", "First Course returned is: " + assignments[0].name);

            }catch(Exception e)
            {
                Log.d("test", e.getMessage());
            }
            return assignments;

        }



    }

    public void getAssignmentlist(String id)
    {

        assignment_course_id = id;
        new getCanvasCourseAssignments().execute("");
        lv_assignments.setAdapter(assignmentAdapter);


    }

}
