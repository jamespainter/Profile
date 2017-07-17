package edu.weber.jamespainter.canvasrestapi;

import android.os.AsyncTask;
import android.support.v4.app.Fragment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import javax.net.ssl.HttpsURLConnection;


import javax.net.ssl.HttpsURLConnection;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Gson gson = new Gson();
        if(savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction().add(R.id.Canvas_Fragment, new PlaceholderFragment(), "ph").commit();
        }

    }

//    @Override
//    public boolean onCreateOptionsMenu(Menu menu) {
//
//      //  getMenuInflater().inflate(R.menu.main, menu);
//        //return super.onCreateOptionsMenu(menu);
//        return true;
//    }
//
//    @Override
//    public boolean onOptionsItemSelected(MenuItem item) {
//
//        int id = item.getItemId();
//        if(id == R.id.action_settings){
//            return true;
//        }
//
//        return super.onOptionsItemSelected(item);
//    }


    public static class PlaceholderFragment extends Fragment {

        protected Button btn_courses;
        protected ListView lv_courses;
        protected ArrayAdapter<String> courseAdapter;

        public PlaceholderFragment(){
        }

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstancesState)
        {
            View rootview = inflater.inflate(R.layout.fragment_canvas_object, container, false);

            btn_courses = (Button) rootview.findViewById(R.id.btn_courses);
            lv_courses = (ListView) rootview.findViewById(R.id.lv_courses);

            //Simple binding to the ListView
            courseAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_selectable_list_item);
            lv_courses.setAdapter(courseAdapter);

            btn_courses.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    new getCanvasCourses().execute("");
                }
            });

            return rootview;
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

                courseAdapter.clear();
                try {
                    CanvasObjects.Course[] courses = jsonParse(result);
                    for (CanvasObjects.Course course : courses){

                        courseAdapter.add(course.name);

                    }


                }catch (Exception e){

                    Log.d("Test", e.getMessage());
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

    }
}
