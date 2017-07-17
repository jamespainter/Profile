package edu.weber.jamespainter.cs3270a7;


import android.database.Cursor;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.ListFragment;
import android.support.v4.widget.CursorAdapter;
import android.support.v4.widget.SimpleCursorAdapter;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ListView;
import android.widget.ScrollView;


/**
 * A simple {@link Fragment} subclass.
 */
public class CourseListFragment extends ListFragment{



    public CourseListFragment() {
        // Required empty public constructor
    }

    private String[] items = new String[] {"one", "two", "three"};
    private String[] digits = new String[]{"1", "2", "3"};

    protected Cursor courseCursor;



    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

/*
        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Music", null, 1);
        Cursor cursor = dbHelper.getAllSongs();
        String[] columns = new String[] {"title"};
        int[] views = new int[] {android.R.id.text1};
        SimpleCursorAdapter adapter = new SimpleCursorAdapter(getActivity(), android.R.layout.simple_list_item_1, cursor, columns, views, CursorAdapter.FLAG_REGISTER_CONTENT_OBSERVER);
        setListAdapter(adapter);
*/




        new getAllCourses().execute("");
        return super.onCreateView(inflater, container, savedInstanceState);
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

}
