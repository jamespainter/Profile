package edu.weber.jamespainter.cs3270a8;


import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.ImageButton;


/**
 * A simple {@link Fragment} subclass.
 */
public class CourseEditFragment extends Fragment {

    View rootView;

    private EditText et_edit_id;
    private EditText et_edit_course_name;
    private EditText et_edit_course_code;
    private EditText et_edit_start_date;
    private EditText et_edit_end_date;
    private ImageButton btn_save;

    private static long selected_courseid = 0;

    public CourseEditFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView =  inflater.inflate(R.layout.fragment_course_edit, container, false);

        et_edit_id = (EditText) rootView.findViewById(R.id.et_edit_id);
        et_edit_course_name = (EditText) rootView.findViewById(R.id.et_edit_course_name);
        et_edit_course_code = (EditText) rootView.findViewById(R.id.et_edit_course_code);
        et_edit_start_date = (EditText) rootView.findViewById(R.id.et_edit_start_date);
        et_edit_end_date = (EditText) rootView.findViewById(R.id.et_edit_end_date);
        btn_save = (ImageButton) rootView.findViewById(R.id.btn_save);


        btn_save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                MainActivity ma = (MainActivity) getActivity();
                if(ma != null)
                {
                    ma.updateCourse();
                }
            }
        });

        return rootView;
    }

    public void populateCourse(long id)
    {
        selected_courseid = id;
        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1);

        Cursor cursor = dbHelper.getSingleCourse(id);
        cursor.moveToFirst(); //This is essential and often missed

        String ID = cursor.getString(cursor.getColumnIndex("ID"));
        String Name = cursor.getString(cursor.getColumnIndex("Name"));
        String Code = cursor.getString(cursor.getColumnIndex("Code"));
        String StartDate = cursor.getString(cursor.getColumnIndex("StartDate"));
        String EndDate = cursor.getString(cursor.getColumnIndex("EndDate"));



        et_edit_id.setText(ID);
        et_edit_course_name.setText(Name);
        et_edit_course_code.setText(Code);
        et_edit_start_date.setText(StartDate);
        et_edit_end_date.setText(EndDate);



    }

    public void updateCourse()
    {
        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1);
        String ID = et_edit_id.getText().toString();
        String Name = et_edit_course_name.getText().toString();
        String Code = et_edit_course_code.getText().toString();
        String StartDate = et_edit_start_date.getText().toString();
        String EndDate = et_edit_end_date.getText().toString();
        dbHelper.updateCourse(selected_courseid,ID, Name, Code, StartDate, EndDate);
    }

    public void deleteCourse()
    {

        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1);
        dbHelper.deleteCourse(selected_courseid);

    }



}
