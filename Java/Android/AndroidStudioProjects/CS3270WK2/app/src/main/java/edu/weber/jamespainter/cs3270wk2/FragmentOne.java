package edu.weber.jamespainter.cs3270wk2;


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
        TextView txtCaption2;
        final TextView txtCaption;
        Button btnChangeCaption;

        View rootView = inflater.inflate(R.layout.fragment_one, container, false);

        txtCaption2 = (TextView) rootView.findViewById(R.id.textView2);
        txtCaption = (TextView) rootView.findViewById(R.id.textView);
        btnChangeCaption = (Button) rootView.findViewById(R.id.btnChangeCaption);

        btnChangeCaption.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
             //   txtCaption.setText("This is onclick listener");
            }
        });
        //  txtCaption.setText("This is in the onCreate(Bundle savedInstanceState)");
        txtCaption2.setText(txtCaption.getText().toString());
        return rootView;
    }

}
