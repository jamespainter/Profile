package edu.weber.jamespainter.cs3270a8;

import android.app.Fragment;
import android.app.FragmentManager;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.TextView;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;

import javax.net.ssl.HttpsURLConnection;

public class MainActivity extends AppCompatActivity {

  private AddCourseViewFragment cvf;
  private ImageButton btn_add;
  private ListView lv_courses;
  private LinearLayout l_acvf;
  private LinearLayout l_cef;
  private LinearLayout l_cvf;
  private LinearLayout l_clf;
  private LinearLayout l_af;
  private static  Menu menu1;
  private static String decision  = "";
  private ArrayList<String> list;
  private static long courseId = 0;

  protected ArrayAdapter<String> assignmentAdapter;

    CourseListFragment courseListFragment;

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

       // getMenuInflater().inflate(R.menu.main_menu, menu);


        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);
        menu1 = menu;
        try{
            String visibleFragment = getVisibleFragment();//getVisible method return current visible fragment
            String shareVisible= visibleFragment;
            if(shareVisible.equals("acvf")
                    ||shareVisible.equals("clf")
                    ){
                MenuItem item1 = menu.findItem(R.id.item_edit);
                MenuItem item2 = menu.findItem(R.id.item_delete);
                item1.setVisible(false);
                item2.setVisible(false);
            }


        }
        catch (Exception e)
        {
            System.out.println("ERROR" + e.toString());
        }

        return true;
    }
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
//

        CourseEditFragment editCourse = (CourseEditFragment) getSupportFragmentManager().findFragmentByTag("cef");
        CourseViewFragment viewCourse = (CourseViewFragment) getSupportFragmentManager().findFragmentByTag("cvf");
        CourseListFragment courseList = (CourseListFragment) getSupportFragmentManager().findFragmentByTag("clf");
        int id = item.getItemId();
        if(id == R.id.item_delete){
            if(viewCourse != null) {
                AreYouSureFragment dialog = new AreYouSureFragment();
                dialog.setCancelable(true);
                dialog.show(getSupportFragmentManager(), "Question");
                MenuItem item1 = menu1.findItem(R.id.item_edit);
                MenuItem item2 = menu1.findItem(R.id.item_delete);
                item1.setVisible(false);
                item2.setVisible(false);
            }

            return true;
        }
       // reloadCourseListFragment();
        if(id == R.id.item_edit){
            if(viewCourse != null){
                //editCourse.updateCourse();
                if(editCourse != null)
                {
                    editCourse.populateCourse(courseId);
                }
                l_cvf.setVisibility(View.GONE);
                l_cef.setVisibility(View.VISIBLE);
                MenuItem item1 = menu1.findItem(R.id.item_edit);
                MenuItem item2 = menu1.findItem(R.id.item_delete);
                item1.setVisible(false);
                item2.setVisible(false);
            }
            //reloadCourseListFragment();
            return true;
        }
        if(id == R.id.item_import_canvas)
        {
            if(courseList != null)
            {
                courseList.importCanvasCourses();

            }


            return true;
        }
        if(id == R.id.item_reload_list)
        {

           reloadCourseListFragment();

            return true;
        }
        return super.onOptionsItemSelected(item);
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
//        list = new ArrayList<>()
//        courseAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, list);



        if(savedInstanceState == null)
        {
            getSupportFragmentManager().beginTransaction().add(R.id.add_course_view_fragment, new AddCourseViewFragment(), "acvf")
                                                            .add(R.id.course_view_fragment, new CourseViewFragment(), "cvf")
                                                            .add(R.id.course_list_fragment, new CourseListFragment(),"clf")
                                                            .add(R.id.course_edit_fragment, new CourseEditFragment(), "cef")
                                                            .add(R.id.course_assignment_fragment, new AssignmentFragment(),"af")
                                                            .commit();
        }
        l_acvf = (LinearLayout) findViewById(R.id.add_course_view_fragment);
        l_cvf = (LinearLayout) findViewById(R.id.course_view_fragment);
        l_cef = (LinearLayout) findViewById(R.id.course_edit_fragment);
        l_clf = (LinearLayout) findViewById(R.id.course_list_fragment);
        l_af = (LinearLayout) findViewById(R.id.course_assignment_fragment);

        btn_add = (ImageButton) findViewById(R.id.btn_add);
        btn_add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

               l_acvf.setVisibility(View.VISIBLE);

            }
        });



    }

    public String getVisibleFragment()
    {
        FragmentManager myFragmentMgr= getFragmentManager();
      //  FragmentTransaction myTransaction = myFragmentMgr.beginTransaction();
        Fragment cef = myFragmentMgr.findFragmentByTag("cef");
        Fragment acvf = myFragmentMgr.findFragmentByTag("acvf");
        Fragment clf = myFragmentMgr.findFragmentByTag("clf");
        Fragment cvf = myFragmentMgr.findFragmentByTag("cvf");

        if(cef != null && cef.isVisible())
        {
            return "cef";
        }
        else if ( acvf != null && acvf.isVisible())
        {
            return "acvf";
        }
        else //if(clf != null && clf.isVisible())
        {
            return  "clf";
        }
    }

    public void reloadCourseListFragment()
    {

// hide the AddCourseViewFragment after a save in CourseView Fragment
//        cvf = (AddCourseViewFragment) getSupportFragmentManager().findFragmentByTag("cvf");
//        android.support.v4.app.FragmentManager fragmentManager = getSupportFragmentManager();
//        fragmentManager.beginTransaction().hide(cvf).commit();
        MenuItem item1 = menu1.findItem(R.id.item_edit);
        MenuItem item2 = menu1.findItem(R.id.item_delete);
        item1.setVisible(false);
        item2.setVisible(false);
        l_acvf.setVisibility(View.GONE);
        l_cef.setVisibility(View.GONE);
        l_cvf.setVisibility(View.GONE);
        l_af.setVisibility(View.GONE);
//reload the list frag
       getSupportFragmentManager().beginTransaction().replace(R.id.course_list_fragment, new CourseListFragment(), "clf").commit();

    }


    public void populateCourse(long id)
    {
        /*
        l_cef.setVisibility(View.VISIBLE);

       CourseEditFragment iFrag = (CourseEditFragment) getSupportFragmentManager().findFragmentByTag("cef");
       if(iFrag != null)
       {
           iFrag.populateCourse(id);
           MenuItem item1 = menu1.findItem(R.id.item_edit);
           MenuItem item2 = menu1.findItem(R.id.item_delete);
           item1.setVisible(true);
           item2.setVisible(true);
       }
       */
        courseId = id;
        l_cvf.setVisibility(View.VISIBLE);
        CourseViewFragment iFrag = (CourseViewFragment) getSupportFragmentManager().findFragmentByTag("cvf");
        if(iFrag != null)
        {
            iFrag.populateCourse(id);
            MenuItem item1 = menu1.findItem(R.id.item_edit);
            MenuItem item2 = menu1.findItem(R.id.item_delete);
            item1.setVisible(true);
            item2.setVisible(true);
        }


    }

    public void setDecision(String message)
    {

        decision = message;
        CourseViewFragment viewCourse = (CourseViewFragment) getSupportFragmentManager().findFragmentByTag("cvf");
        if (decision == "Yes"){
            viewCourse.deleteCourse();
        }
        reloadCourseListFragment();
    }


    public void updateCourse(){

        CourseEditFragment editCourse = (CourseEditFragment) getSupportFragmentManager().findFragmentByTag("cef");
        if(editCourse != null){
            editCourse.updateCourse();
            MenuItem item1 = menu1.findItem(R.id.item_edit);
            MenuItem item2 = menu1.findItem(R.id.item_delete);
            item1.setVisible(false);
            item2.setVisible(false);
        }
        reloadCourseListFragment();

    }

    public void getAssignmentList(String id)
    {
        AssignmentFragment af = (AssignmentFragment) getSupportFragmentManager().findFragmentByTag("af");

        if(af != null)
        {
            af.getAssignmentlist(id);
        }

        l_af.setVisibility(View.VISIBLE);



    }

//    public class getCanvasCourseAssignments extends AsyncTask<String, Integer, String> {
//
//        // Create a separate public final class to hold your token
//        String AUTH_TOKEN = Authorization.AUTH_TOKEN;
//
//        String rawJson = "";
//
//        @Override
//        protected String doInBackground(String... params) {
//            Log.d("test", "In AsyncTask getCanvasCourses");
//            try{
//                URL url = new URL("https://weber.instructure.com/api/v1/courses/"+ assignment_course_id +"/assignments");
//                HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
//                conn.setRequestMethod("GET");
//                conn.setRequestProperty("Authorization", "Bearer " + AUTH_TOKEN);
//                int status = conn.getResponseCode();
//                switch (status)
//                {
//                    case 200: //200 or 201 indicate success
//                    case 201:
//                        BufferedReader br =
//                                new BufferedReader(new InputStreamReader(conn.getInputStream()));
//                        rawJson = br.readLine();
//                        Log.d("Test","raw Json String Length = " + rawJson.length());
//                        Log.d("Test", "raw Json first 256 chars: "+ rawJson.substring(0, 256));
//                        Log.d("Test", "raw Json first 256 chars: "+ rawJson.substring(rawJson.length()));
//
//                }
//
//
//            }
//            catch(MalformedURLException e)
//            {
//                Log.d("Test", e.getMessage());
//                System.out.println(e.toString());
//            }
//            catch(IOException e){
//                Log.d("Test", e.getMessage());
//            }
//            return rawJson;
//        }
//
//        @Override
//        protected void onPostExecute(String result){
//
//            super.onPostExecute(result);
//
//            assignmentAdapter.clear();
//            try {
//                CanvasObjects.Assignment[] assignments = jsonParse(rawJson);
//                for (CanvasObjects.Assignment assignment : assignments){
//
//                    assignmentAdapter.add(assignment.name);
//
//                }
//
//
//            }catch (Exception e){
//
//                Log.d("Test", e.getMessage());
//            }
//
//        }
//
//        private CanvasObjects.Assignment[] jsonParse(String rawJson)
//        {
//            CanvasObjects.Assignment[] assignments = null;
//            GsonBuilder gsonb = new GsonBuilder();
//            Gson gson = gsonb.create();
//
//            try{
//                assignments = gson.fromJson(rawJson, CanvasObjects.Assignment[].class);
//                Log.d("Test","Number of courses returned is: " + assignments.length);
//                Log.d("Test", "First Course returned is: " + assignments[0].name);
//
//            }catch(Exception e)
//            {
//                Log.d("test", e.getMessage());
//            }
//            return assignments;
//
//        }
//
//
//
//    }


}
