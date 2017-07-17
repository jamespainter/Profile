package edu.weber.jamespainter.w2fragments;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentOne extends Fragment {


    public FragmentOne() {
        // Required empty public constructor

    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView =  inflater.inflate(R.layout.fragment_one, container, false);
        TextView Caption2;
        final TextView btnCaption1;

        Button btnChangeCaption;



        Caption2 = (TextView) rootView.findViewById(R.id.textView2);
        btnCaption1 = (TextView) rootView.findViewById(R.id.textView3);
        btnChangeCaption = (Button) rootView.findViewById(R.id.button);



        Caption2.setText("Lets do more");

        btnChangeCaption.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                btnCaption1.setText("This after click of the button");

            }
        });

        return rootView;
    }

}
