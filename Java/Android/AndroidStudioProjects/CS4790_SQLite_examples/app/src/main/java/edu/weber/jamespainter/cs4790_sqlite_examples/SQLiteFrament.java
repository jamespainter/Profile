package edu.weber.jamespainter.cs4790_sqlite_examples;


import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class SQLiteFrament extends Fragment {

    View rootView;

    EditText et_title;
    EditText et_artist;
    EditText et_genre;

    Button btn_insert_song;


    public SQLiteFrament() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView =  inflater.inflate(R.layout.fragment_sqlite_frament, container, false);

        et_title = (EditText) rootView.findViewById(R.id.et_title);
        et_artist = (EditText) rootView.findViewById(R.id.et_artist);
        et_genre = (EditText) rootView.findViewById(R.id.et_genre);
        btn_insert_song = (Button) rootView.findViewById(R.id.btn_insert_song);



        btn_insert_song.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Music", null, 1);
                long rowID = dbHelper.insertSong(
                        et_title.getText().toString(),
                        et_artist.getText().toString(),
                        et_genre.getText().toString()
                );

                MainActivity ma = (MainActivity) getActivity();
                ma.reloadBottomFragment();
            }
        });

        return rootView;
    }
    public void populateSong(long id)
    {
         DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Music",null, 1);
         Cursor cursor = dbHelper.getOneSong(id);
         cursor.moveToFirst(); //This is essential and often missed

        String title = cursor.getString(cursor.getColumnIndex("title"));
        String artist = cursor.getString(cursor.getColumnIndex("artist"));
        String genre = cursor.getString(cursor.getColumnIndex("genre"));

        et_title.setText(title);
        et_artist.setText(artist);
        et_genre.setText(genre);

    }
}
