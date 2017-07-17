package edu.weber.jamespainter.cs3270mi;


import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import org.w3c.dom.Text;


/**
 * A simple {@link Fragment} subclass.
 */
public class ResultsFragment extends Fragment {

    TextView tv_BFP;
    TextView tv_BFP_value;
    TextView tv_BMI_value;
    TextView tv_BMI;

    View rootView;

    public ResultsFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_results, container, false);

        tv_BFP = (TextView) rootView.findViewById(R.id.tv_BFP);
        tv_BFP_value = (TextView) rootView.findViewById(R.id.tv_BFP_value);
        tv_BMI_value = (TextView) rootView.findViewById(R.id.tv_BMI_value);
        tv_BMI = (TextView) rootView.findViewById(R.id.tv_BMI);






        return rootView;
    }

    @Override
    public void onPause() {
        super.onPause();
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();

        try {
            editor.putString("tv_BFP_value", tv_BFP_value.getText().toString());
            editor.putString("tv_BMI_value", tv_BFP_value.getText().toString());
        }
        catch(Exception e)
        {
            System.out.println(e.toString());
        }
        editor.apply();
    }

    @Override
    public void onResume() {
        super.onResume();
        Log.d("text", "Main Fragment onResume");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        try{
            tv_BFP_value.setText(prefs.getString("tv_BFP_value", "$.00"));
            tv_BMI_value.setText(prefs.getString("tv_BFP_value", "$.00"));
        }
        catch (Exception e)
        {
            System.out.println(e.toString());
        }

    }

    public void setBMIAndBFP(double BMI, double BFP)
    {



        tv_BMI_value.setText(String.format("%.2f",BMI));
        tv_BFP_value.setText(String.format("%.2f",BFP));



    }




}
