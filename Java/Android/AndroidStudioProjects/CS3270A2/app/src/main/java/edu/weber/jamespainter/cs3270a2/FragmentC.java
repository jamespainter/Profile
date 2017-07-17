package edu.weber.jamespainter.cs3270a2;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import org.w3c.dom.Text;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentC extends Fragment {


    public FragmentC() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        TextView tv_c;
        View rootView =  inflater.inflate(R.layout.fragment_c, container, false);

        tv_c = (TextView) rootView.findViewById(R.id.tv_c);

        return rootView;

    }

}
