package edu.weber.jamespainter.cs3270_example_fragment2;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.support.v7.app.AppCompatActivity;

import org.w3c.dom.Text;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentA extends Fragment {

    public String message;
    public View rootView;
    public FragmentA() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
         rootView =  inflater.inflate(R.layout.fragment_a, container, false);
        Button btn_SendToC = (Button) rootView.findViewById(R.id.btn_sendToC);


        btn_SendToC.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                message = "Sent_From_C";
                MainActivity ma = (MainActivity) getActivity();
                ma.SendToC(message);
            }
        });


        return rootView;
    }

}
