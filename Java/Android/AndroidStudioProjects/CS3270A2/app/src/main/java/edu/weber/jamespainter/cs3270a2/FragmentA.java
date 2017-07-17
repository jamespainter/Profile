package edu.weber.jamespainter.cs3270a2;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentA extends Fragment {


    public FragmentA() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        TextView tv_a;

        View rootView = inflater.inflate(R.layout.fragment_a, container, false);

        tv_a = (TextView) rootView.findViewById(R.id.tv_a);



        return rootView;
    }

}
