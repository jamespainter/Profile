package edu.weber.jamespainter.cs4790_sqlite_examples;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

/**
 * Created by JamesPainter on 2/27/2017.
 */

public class DatabaseHelper extends SQLiteOpenHelper {

    private SQLiteDatabase database;

    public DatabaseHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version)
    {
        super(context, name, factory, version);
    }

    public SQLiteDatabase open(){

        database = getWritableDatabase();
        return database;

    }

    public void close()
    {
        if(database != null)
            database.close();

    }

    public long insertSong(String title, String artist, String genre)
    {
        long rowID = -1;

        ContentValues newSong = new ContentValues();
        newSong.put("title", title);
        newSong.put("artist", artist);
        newSong.put("genre", genre);
        if(open() != null){
            rowID = database.insert("songs", null, newSong);
            close();
        }
        return rowID;
    }

//app will not recreate the table
    public long updateSong(long id, String title, String artist, String genre)
    {
        long rowID = -1;

        ContentValues editSong = new ContentValues();
        editSong.put("title", title);
        editSong.put("Artist", artist);
        editSong.put("genre", genre);
        if(open() != null){
            rowID = database.update("songs", editSong, "_id=" +id, null);
            close();
        }

        return rowID;
    }

    public Cursor getAllSongs()
    {
        Cursor cursor = null;
        if(open() != null)
        {
            Log.d("test", "Querying all songs");
            cursor = database.rawQuery("SELECT * FROM songs", null);

        }
        return cursor;
    }


    public Cursor getOneSong(long id)
    {
        String[] params = new String[1];
        params[0] = "" + id;
        Cursor cursor = null;
        if(open() != null){
            cursor = database.rawQuery("SELECT * FROM songs WHERE _id =?", params);
        }
        return cursor;
    }

//Every SQLite Database when creating a table needs to have _id integer primary key autoincrement
    @Override
    public void onCreate(SQLiteDatabase db) {
        String createQuery = "CREATE TABLE songs " +
                "(_id integer primary key autoincrement," +
                "title TEXT, artist TEXT, genre TEXT);";
        db.execSQL(createQuery);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
