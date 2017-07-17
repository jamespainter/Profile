package edu.weber.jamespainter.cs3270a4;


import android.content.Context;
import android.content.SharedPreferences;
import android.icu.math.BigDecimal;
import android.os.Build;
import android.os.Bundle;
import android.support.annotation.RequiresApi;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.util.Locale;


/**
 * A simple {@link Fragment} subclass.
 */
@RequiresApi(api = Build.VERSION_CODES.N)
public class TotalsFragment extends Fragment {


    TextView tv_Total_Amount;
    BigDecimal bTotalAmount = new BigDecimal("0");
    @Override
    public void onPause() {
        super.onPause();

//        MainActivity ma = (MainActivity) getActivity();
//        SharedPreferences prefs = ma.getSharedPreferences("TotFrag", Context.MODE_PRIVATE);
//        SharedPreferences.Editor tf_editor = prefs.edit();
//        tf_editor.putString("tv_Total_Amount", tv_Total_Amount.getText().toString());
//        tf_editor.apply();

    }

    @Override
    public void onResume() {
        super.onResume();
//         MainActivity ma = (MainActivity) getActivity();
//        SharedPreferences prefs = ma.getSharedPreferences("TotFrag", Context.MODE_PRIVATE);
//        tv_Total_Amount.setText(prefs.getString(" tv_Total_Amount",""));
    }




    public TotalsFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_totals, container, false);


        tv_Total_Amount = (TextView) rootView.findViewById(R.id.tv_Total_Amount);
        setTotalAmount( bTotalAmount);

        return rootView;
    }


    public void setTotalAmount(BigDecimal totAmt)
    {

        bTotalAmount = totAmt;
        //"Tax Amount $" +
        String DTotalAmount = "$" + String.format(Locale.getDefault(), "%.2f", bTotalAmount.floatValue());
        tv_Total_Amount.setText(DTotalAmount);

    }

//    public void changeTotal(String total1)
//    {
//
//        // tv_Total_Amount = (TextView) rootView.findViewById(R.id.tv_Total_Amount);
//        total = "$" +  total1;
//        tv_Total_Amount.setText("$" + total1);
//
//    }




//
//    public void changeTotal(String total1)
//    {
//
//       // tv_Total_Amount = (TextView) rootView.findViewById(R.id.tv_Total_Amount);
//        total = "$" +  total1;
//        tv_Total_Amount.setText("$" + total1);
//
//    }




}
