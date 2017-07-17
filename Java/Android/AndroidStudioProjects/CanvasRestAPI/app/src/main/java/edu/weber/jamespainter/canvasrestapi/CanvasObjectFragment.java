package edu.weber.jamespainter.canvasrestapi;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class CanvasObjectFragment extends Fragment {
    View rootView;
    TextView tv_canvas_course_listing;
    ListView lv_courses;
    Button btn_courses;

    public CanvasObjectFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_canvas_object, container, false);

        tv_canvas_course_listing = (TextView) rootView.findViewById(R.id.tv_canvas_course_listing);
        lv_courses = (ListView) rootView.findViewById(R.id.lv_courses);
        btn_courses = (Button) rootView.findViewById(R.id.btn_courses);




        return rootView;

    }

}
