package edu.weber.jamespainter.cs3270a7;

import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.database.Cursor;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageButton;
import android.widget.LinearLayout;

public class MainActivity extends AppCompatActivity {

  private  CourseViewFragment cvf;
  private  ImageButton btn_add;
  private  LinearLayout l_cvf;
  private  LinearLayout l_cef;
  private  LinearLayout l_clf;
  private  static  Menu menu1;
  private static String decision  = "";


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

       // getMenuInflater().inflate(R.menu.main_menu, menu);


        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);
        menu1 = menu;
        try{
            String visibleFragment = getVisibleFragment();//getVisible method return current visible fragment
            String shareVisible= visibleFragment;
            if(shareVisible.equals("cvf")
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
        int id = item.getItemId();
        if(id == R.id.item_delete){
            if(editCourse != null) {
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
        if(id == R.id.item_edit){
            if(editCourse != null){
                editCourse.updateCourse();
                MenuItem item1 = menu1.findItem(R.id.item_edit);
                MenuItem item2 = menu1.findItem(R.id.item_delete);
                item1.setVisible(false);
                item2.setVisible(false);
            }
            reloadCourseListFragment();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if(savedInstanceState == null)
        {
            getSupportFragmentManager().beginTransaction().add(R.id.course_view_fragment, new CourseViewFragment(), "cvf")
                                                            .add(R.id.course_list_fragment, new CourseListFragment(),"clf")
                                                            .add(R.id.course_edit_fragment, new CourseEditFragment(), "cef")
                                                            .commit();
        }
        l_cvf = (LinearLayout) findViewById(R.id.course_view_fragment);
        l_cef = (LinearLayout) findViewById(R.id.course_edit_fragment);
        l_clf = (LinearLayout) findViewById(R.id.course_list_fragment);


        btn_add = (ImageButton) findViewById(R.id.btn_add);
        btn_add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

               l_cvf.setVisibility(View.VISIBLE);

            }
        });



    }

    public String getVisibleFragment()
    {
        FragmentManager myFragmentMgr= getFragmentManager();
      //  FragmentTransaction myTransaction = myFragmentMgr.beginTransaction();
        Fragment cef = myFragmentMgr.findFragmentByTag("cef");
        Fragment cvf = myFragmentMgr.findFragmentByTag("cvf");
        Fragment clf = myFragmentMgr.findFragmentByTag("clf");

        if(cef != null && cef.isVisible())
        {
            return "cef";
        }
        else if ( cvf != null && cvf.isVisible())
        {
            return "cvf";
        }
        else //if(clf != null && clf.isVisible())
        {
            return  "clf";
        }

    }
    public void reloadCourseListFragment()
    {


// hide the CourseViewFragment after a save in CourseView Fragment
//        cvf = (CourseViewFragment) getSupportFragmentManager().findFragmentByTag("cvf");
//        android.support.v4.app.FragmentManager fragmentManager = getSupportFragmentManager();
//        fragmentManager.beginTransaction().hide(cvf).commit();
        l_cvf.setVisibility(View.GONE);
        l_cef.setVisibility(View.GONE);
//reload the list frag
       getSupportFragmentManager().beginTransaction().replace(R.id.course_list_fragment, new CourseListFragment(), "clf").commit();

    }


    public void populateCourse(long id)
    {
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


    }

    public void setDecision(String message)
    {


        decision = message;
        CourseEditFragment editCourse = (CourseEditFragment) getSupportFragmentManager().findFragmentByTag("cef");
        if (decision == "Yes"){
            editCourse.deleteCourse();
        }
        reloadCourseListFragment();
    }


}
