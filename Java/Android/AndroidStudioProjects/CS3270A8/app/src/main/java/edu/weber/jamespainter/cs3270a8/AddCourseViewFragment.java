package edu.weber.jamespainter.cs3270a8;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class AddCourseViewFragment extends Fragment {

    View rootView;

   private TextView tv_id;
   private EditText et_id;
   private TextView tv_name;
   private EditText et_name;
   private TextView tv_code;
   private EditText et_code;

   private TextView tv_view_start_date;
   private EditText et_view_start_date;

   private TextView tv_view_end_date;
   private EditText et_view_end_date;

   private ImageButton btn_save;
   private ImageButton btn_delete_create;





    public AddCourseViewFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_add_course_view, container, false);

        tv_id = (TextView) rootView.findViewById(R.id.tv_id);
        tv_name = (TextView) rootView.findViewById(R.id.tv_name);
        tv_code = (TextView) rootView.findViewById(R.id.tv_code);


        tv_view_start_date = (TextView) rootView.findViewById(R.id.tv_view_start_date);

        tv_view_end_date = (TextView) rootView.findViewById(R.id.tv_view_end_date);

        et_id = (EditText) rootView.findViewById(R.id.et_id);
        et_name = (EditText) rootView.findViewById(R.id.et_name);
        et_code = (EditText) rootView.findViewById(R.id.et_code);

        et_view_start_date = (EditText) rootView.findViewById(R.id.et_view_start_date);

        et_view_end_date = (EditText) rootView.findViewById(R.id.et_view_end_date);

        btn_save = (ImageButton) rootView.findViewById(R.id.btn_save);
        btn_delete_create = (ImageButton) rootView.findViewById(R.id.btn_delete_create);
        btn_delete_create.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1 );
                dbHelper.CreatCoursesTable();
            }
        });

        btn_save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1 );
                long rowID = dbHelper.insertCourse(

                        et_id.getText().toString(),
                        et_name.getText().toString(),
                        et_code.getText().toString(),
                        et_view_start_date.getText().toString(),
                        et_view_end_date.getText().toString()



                );
               et_id.setText("");
               et_name.setText("");
               et_code.setText("");
               et_view_start_date.setText("");
               et_view_end_date.setText("");

                MainActivity ma = (MainActivity) getActivity();
                ma.reloadCourseListFragment();

            }
        });

        return rootView;
    }

}
