package edu.weber.jamespainter.cs3270a4;


import android.content.Context;
import android.content.SharedPreferences;
import android.icu.math.BigDecimal;
import android.os.Build;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.RequiresApi;
import android.support.v4.app.Fragment;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import java.util.Collection;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.ListIterator;


/**
 * A simple {@link Fragment} subclass.
 */
@RequiresApi(api = Build.VERSION_CODES.N)
public class ItemsFragment extends Fragment {


    BigDecimal itemTotals = BigDecimal.ZERO;
    EditText et_item1;
    EditText et_item2;
    EditText et_item3;
    EditText et_item4;





    public ItemsFragment() {
        // Required empty public constructor
    }



    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        View rootView =  inflater.inflate(R.layout.fragment_items, container, false);

        et_item1 = (EditText) rootView.findViewById(R.id.et_Item_Amount1_Value);
        et_item2 = (EditText) rootView.findViewById(R.id.et_Item_Amount2_Value);
        et_item3 = (EditText) rootView.findViewById(R.id.et_Item_Amount3_Value);
        et_item4 = (EditText) rootView.findViewById(R.id.et_Item_Amount4_Value);



        et_item1.addTextChangedListener(amtChanged);
        et_item2.addTextChangedListener(amtChanged);
        et_item3.addTextChangedListener(amtChanged);
        et_item4.addTextChangedListener(amtChanged);




        return rootView;
    }


    TextWatcher amtChanged = new TextWatcher() {
        @Override
        public void beforeTextChanged(CharSequence s, int start, int count, int after) {

        }

        @Override
        public void onTextChanged(CharSequence s, int start, int before, int count) {

        }

        @Override
        public void afterTextChanged(Editable s) {
            updateItemTotals();
        }
    };

    public void updateItemTotals(){
        //declare BigDecimal
        BigDecimal iItem1, iItem2, iItem3, iItem4;
        //convert to BigDecimal
        iItem1 = stringToBig(et_item1.getText().toString());
        iItem2 = stringToBig(et_item2.getText().toString());
        iItem3 = stringToBig(et_item3.getText().toString());
        iItem4 = stringToBig(et_item4.getText().toString());
        //add totals of each item of each Edit Text
        itemTotals = iItem1;
        itemTotals = itemTotals.add(iItem2);
        itemTotals = itemTotals.add(iItem3);
        itemTotals = itemTotals.add(iItem4);
        //push to Main activity everytime there is an update to any of the Edit Text items
        MainActivity ma = (MainActivity) getActivity();
        ma.setItemsTotal(itemTotals);




    }

    public BigDecimal stringToBig(String et_item)
    {

        BigDecimal retVal = new BigDecimal("0");
        if(et_item != null){
            if(et_item.length() > 0){

                retVal = new BigDecimal(et_item);

            }
        }

        return retVal;
    }

//
//   public void getSum()
//   {
//       MainActivity ma = (MainActivity) getActivity();
//       itemTotal = itemTotal1 + itemTotal2 + itemTotal3 + itemTotal4;
//       ma = (MainActivity) getActivity();
//       ma.setTotal(String.format("%.2f", itemTotal));
//
//   }

    @Override
    public void onPause() {
        super.onPause();
        MainActivity ma = (MainActivity) getActivity();
        SharedPreferences prefs = ma.getSharedPreferences("ItemFrag", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putString("et_item1", et_item1.getText().toString());
        editor.putString("et_item2", et_item2.getText().toString());
        editor.putString("et_item3", et_item3.getText().toString());
        editor.putString("et_item4", et_item1.getText().toString());
        editor.apply();

    }

    @Override
    public void onResume() {
        super.onResume();

        MainActivity ma = (MainActivity) getActivity();
        SharedPreferences prefs = ma.getSharedPreferences("ItemFrag", Context.MODE_PRIVATE);
        et_item1.setText(prefs.getString("et_item1",""));
        et_item2.setText(prefs.getString("et_item2",""));
        et_item3.setText(prefs.getString("et_item3",""));
        et_item4.setText(prefs.getString("et_item4",""));


    }


}
