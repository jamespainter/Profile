package edu.weber.jamespainter.cs3270a8;

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
// open connection
    public SQLiteDatabase open(){

        database = getWritableDatabase();
        return database;

    }
// close connection
    public void close()
    {
        if(database != null)
            database.close();

    }

// insert/enter a new course into the courses table
    public long insertCourse(String course_ID, String course_name, String course_code, String startDate, String endDate)
    {
        long rowID = -1;

        ContentValues newCourse = new ContentValues();
        newCourse.put("ID", course_ID);
        newCourse.put("Name", course_name);
        newCourse.put("Code", course_code);
        newCourse.put("StartDate", startDate);
        newCourse.put("EndDate", endDate);
        if(open() != null){
            rowID = database.insert("courses", null, newCourse);
            close();
        }
        return rowID;
    }

// update/edit a course in the courses table

    public long updateCourse(long id, String course_ID, String course_name, String course_code, String startDate, String endDate)
    {
        long rowID = -1;

        ContentValues updateCourse = new ContentValues();
        updateCourse.put("ID", course_ID);
        updateCourse.put("Name", course_name);
        updateCourse.put("Code", course_code);
        updateCourse.put("StartDate",startDate );
        updateCourse.put("EndDate", endDate);
        if(open() != null)
        {
            rowID = database.update("courses", updateCourse, "_id ="+ id, null );
            close();
        }
        return rowID;

    }



// Delete course in the courses tables
// Delete dialog to get confirmation to delete course record
    public long deleteCourse(long id)
    {
        long rowID = -1;
       //Delete Dialog and if for confirmation condition
//        ContentValues deleteCourse = new ContentValues();
//        deleteCourse.put("ID", course_ID);
//        deleteCourse.put("Name", course_name);
//        deleteCourse.put("Code", course_code);
        if(open() != null)
        {
            rowID = database.delete("courses","_id = " + id , null);
            close();
        }
        return rowID;
    }

//get all course for the CouserView Fragment

    public Cursor getAllCourse()
    {
        Cursor cursor = null;
        if(open() != null)
        {
            Log.d("test", "Querying all courses");
            cursor = database.rawQuery("SELECT * FROM courses", null);

        }
        return cursor;
    }

    public Cursor getSingleCourse(long id)
    {
        String[] params = new String[1];
        params[0] = "" + id;
        Cursor cursor = null;
        if(open() != null)
        {
            Log.d("text", "Querying one Course");
            cursor = database.rawQuery("SELECT * FROM courses WHERE _id = ?", params);
        }
        return cursor;
    }
    public Cursor getCourseID(long id)
    {
        String[] params = new String[1];
        params[0] = "" + id;
        Cursor cursor = null;
        if(open() != null)
        {
            Log.d("text", "Querying one Course");
            cursor = database.rawQuery("SELECT ID FROM courses WHERE _id = ?", params);
        }
        return cursor;
    }


    public void CreatCoursesTable()
    {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL("DROP TABLE IF EXISTS Courses");

        String createQuery = "CREATE TABLE courses " +
                "(_id integer primary key autoincrement," +
                "ID TEXT, Name TEXT, Code TEXT, StartDate TEXT, EndDate TEXT);";
//        String createQuery = "DROP TABLE courses";
//       db.execSQL("delete from courses");
        db.execSQL(createQuery);

    }



//Every SQLite Database when creating a table needs to have _id integer primary key autoincrement
    @Override
    public void onCreate(SQLiteDatabase db) {
        String createQuery = "CREATE TABLE courses " +
                "(_id integer primary key autoincrement," +
                "ID TEXT, Name TEXT, Code TEXT, StartDate TEXT, EndDate TEXT);";

        db.execSQL(createQuery);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
