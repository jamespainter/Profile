package edu.weber.jamespainter.cs4790_sqlite_examples;


import android.app.Activity;
import android.database.Cursor;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.ListFragment;
import android.support.v4.view.ScrollingView;
import android.support.v4.widget.CursorAdapter;
import android.support.v4.widget.SimpleCursorAdapter;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.ScrollView;


/**
 * A simple {@link Fragment} subclass.
 */
public class BottomFragment extends ListFragment {

    View rootView;

    ScrollView sv_scroll_view;

    private String[] items = new String[] {"one", "two", "three"};
    private String[] digits = new String[]{"1", "2", "3"};

    protected Cursor songCursor;

    public BottomFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
       rootView =  inflater.inflate(R.layout.fragment_bottom, container, false);

        sv_scroll_view = (ScrollView) rootView.findViewById(R.id.sv_database);
/*
        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Music", null, 1);
        Cursor cursor = dbHelper.getAllSongs();
        String[] columns = new String[] {"title"};
        int[] views = new int[] {android.R.id.text1};
        SimpleCursorAdapter adapter = new SimpleCursorAdapter(getActivity(), android.R.layout.simple_list_item_1, cursor, columns, views, CursorAdapter.FLAG_REGISTER_CONTENT_OBSERVER);
        setListAdapter(adapter);
*/
        new getAllSongs().execute("");
        return super.onCreateView(inflater, container, savedInstanceState);
    }

    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        super.onListItemClick(l, v, position, id);

        Log.d("test", "ListView position:" + position +" - id:" + id);
        MainActivity ma = (MainActivity) getActivity();
        ma.populateSong(id);


    }
//AsyncTask is a way to do multi-threading. <String/Activity is what we are passing to the do in
//background Integer is on progress, Cursor is the same of the onPostExecute
public class getAllSongs extends AsyncTask<String, Integer, Cursor>
{


        @Override
        protected Cursor doInBackground(String... params) {

            DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Music", null, 1);
            Cursor cursor = dbHelper.getAllSongs();
            return cursor;

        }

        @Override
        protected void onPostExecute(Cursor cursor) {
            super.onPostExecute(cursor);

            String[] columns = new String[] {"title"};
            int[] views = new int[] {android.R.id.text1};
            SimpleCursorAdapter adapter = new SimpleCursorAdapter(getActivity(), android.R.layout.simple_list_item_1,
                                            cursor, columns, views, CursorAdapter.FLAG_REGISTER_CONTENT_OBSERVER);
            setListAdapter(adapter);

        }
    }
}
