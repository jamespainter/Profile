package edu.weber.jamespainter.cs3270a4;


import android.annotation.TargetApi;
import android.content.Context;
import android.content.SharedPreferences;
import android.icu.math.BigDecimal;
import android.os.Build;
import android.os.Bundle;
import android.support.annotation.RequiresApi;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.SeekBar;
import android.widget.TextView;

import java.util.Locale;


/**
 * A simple {@link Fragment} subclass.
 */
@RequiresApi(api = Build.VERSION_CODES.N)
public class TaxFragment extends Fragment {


    public SeekBar sb_taxRate;
    TextView tv_Tax_Rate_Value, tv_Tax_Amount;
    int seekBarPos = 0;
    BigDecimal bTaxRate;


    public TaxFragment() {
        // Required empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_tax, container, false);
        sb_taxRate = (SeekBar) rootView.findViewById(R.id.sb_tax);
        tv_Tax_Rate_Value = (TextView) rootView.findViewById(R.id.tv_Tax_Rate_Value);
        tv_Tax_Amount = (TextView) rootView.findViewById(R.id.tv_Tax_Amount_Value);


        sb_taxRate.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {

            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                seekBarPos = progress;
                updateTaxRate(progress);

            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });

        return rootView;
    }


    @Override
    public void onResume() {
        super.onResume();

        MainActivity ma = (MainActivity) getActivity();
        SharedPreferences prefs = ma.getSharedPreferences("TaxFrag", Context.MODE_PRIVATE);
        seekBarPos = prefs.getInt("seekBarPos",0);
        sb_taxRate.setProgress(seekBarPos);
        tv_Tax_Rate_Value.setText(prefs.getString("tv_Tax_Rate_Value",""));
        tv_Tax_Amount.setText(prefs.getString("tv_Tax_Amount",""));

    }

    @Override
    public void onPause() {
        super.onPause();
        MainActivity ma = (MainActivity) getActivity();
        SharedPreferences prefs = ma.getSharedPreferences("TaxFrag", Context.MODE_PRIVATE);
        SharedPreferences.Editor tf_editor = prefs.edit();
        tf_editor.putInt("seekBarPos", seekBarPos);
        tf_editor.putString("tv_Tax_Rate_Value", tv_Tax_Rate_Value.getText().toString());
        tf_editor.putString("tv_Tax_Amount", tv_Tax_Amount.getText().toString());
        tf_editor.apply();

    }




    @RequiresApi(api = Build.VERSION_CODES.N)
    private void updateTaxRate(int i)
    {
        bTaxRate = new BigDecimal(i);
        bTaxRate = bTaxRate.divide(new BigDecimal(4),BigDecimal.ROUND_HALF_UP);
        String sTaxRate = String.format(Locale.getDefault(), "%.2f", bTaxRate.floatValue());
        //May have to change this ************************
        tv_Tax_Rate_Value.setText(sTaxRate + "%");

        MainActivity ma = (MainActivity) getActivity();
        BigDecimal itemsTotal = ma.getItemsTotal();
        BigDecimal dTaxAmt = itemsTotal.multiply(bTaxRate).divide(new BigDecimal(100),BigDecimal.ROUND_HALF_UP);
        String sTaxAmt = "$" + String.format(Locale.getDefault(), "%.2f", dTaxAmt.floatValue());
        tv_Tax_Amount.setText(sTaxAmt);
        ma.setTaxAmount(dTaxAmt);




    }


//
//    public void setTaxAmount(String total_Amount)
//    {
//        //System.out.println(tv_Tax_Rate_Value.getText().toString());
//        tx_Rate_Amount = (interest/100) * Float.parseFloat(total_Amount);
//
//       // tv_Tax_Amount = (TextView) rootView.findViewById(R.id.tv_Tax_Amount_Value);
//        TotalAmount = String.format("%.2f", tx_Rate_Amount);
//        tv_Tax_Amount.setText(String.format("$" + "%.2f", tx_Rate_Amount));
//
//    }
//
//    public void setAdjust(String total_Amount)
//    {
//
//        tx_Rate_Amount = (interest/100) * Float.parseFloat(total_Amount);
//        tv_Tax_Amount.setText(String.format("$" + "%.2f", tx_Rate_Amount));
//
//    }




}
