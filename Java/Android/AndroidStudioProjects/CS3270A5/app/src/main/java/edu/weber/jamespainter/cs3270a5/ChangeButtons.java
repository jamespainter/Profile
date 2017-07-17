package edu.weber.jamespainter.cs3270a5;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.view.View.OnClickListener;

/**
 * A simple {@link Fragment} subclass.
 */
public class ChangeButtons extends Fragment implements OnClickListener {


    View rootView;

//Buttons
    Button btn_50;
    Button btn_20;
    Button btn_10;
    Button btn_5;
    Button btn_1;
    Button btn_050;
    Button btn_020;
    Button btn_010;
    Button btn_05;
    Button btn_01;



    public ChangeButtons() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
       rootView =  inflater.inflate(R.layout.fragment_change_buttons, container, false);

        btn_50 = (Button) rootView.findViewById(R.id.btn_50);
        btn_50.setOnClickListener(this);
        btn_20 = (Button) rootView.findViewById(R.id.btn_20);
        btn_20.setOnClickListener(this);
        btn_10 = (Button) rootView.findViewById(R.id.btn_10);
        btn_10.setOnClickListener(this);
        btn_5 = (Button) rootView.findViewById(R.id.btn_5);
        btn_5.setOnClickListener(this);
        btn_1 = (Button) rootView.findViewById(R.id.btn_1);
        btn_1.setOnClickListener(this);
        btn_050 =(Button) rootView.findViewById(R.id.btn_050);
        btn_050.setOnClickListener(this);
        btn_020 = (Button) rootView.findViewById(R.id.btn_020);
        btn_020.setOnClickListener(this);
        btn_010 = (Button) rootView.findViewById(R.id.btn_010);
        btn_010.setOnClickListener(this);
        btn_05 = (Button) rootView.findViewById(R.id.btn_05);
        btn_05.setOnClickListener(this);
        btn_01 = (Button) rootView.findViewById(R.id.btn_01);
        btn_01.setOnClickListener(this);




        return rootView;
    }

    @Override
    public void onClick(View v)
    {
        MainActivity ma = (MainActivity) getActivity();
        switch (v.getId()) {
            case R.id.btn_50:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(50f);
                }
                break;
            case R.id.btn_20:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(20f);
                }
                break;
            case R.id.btn_10:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(10f);
                }
                break;
            case R.id.btn_5:
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(5f);
                }
                // do your code
                break;
            case R.id.btn_1:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(1f);
                }
                break;
            case R.id.btn_050:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(0.50f);
                }
                break;
            case R.id.btn_020:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(0.20f);
                }
                break;
            case R.id.btn_010:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(0.10f);
                }
                break;
            case R.id.btn_05:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(0.05f);
                }
                break;
            case R.id.btn_01:
                // do your code
                if(!ma.equals(null))
                {
                    ma.addChangeSoFarTotal(0.01f);
                }
                break;

            default:
                break;
        }


    }

}
