package edu.weber.jamespainter.cs3270_example_fragment2;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentC extends Fragment {

    public  View rootView;
    public TextView tv_message;
    public FragmentC() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView =  inflater.inflate(R.layout.fragment_c, container, false);
        tv_message = (TextView) rootView.findViewById(R.id.tv_Fragment_C);



        return rootView;
    }

    public void setMessage(String message)
    {

        tv_message.setText(message);
    }

}
