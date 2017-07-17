package edu.weber.jamespainter.cs3270a4;

import android.content.SharedPreferences;
import android.icu.math.BigDecimal;
import android.os.Build;
import android.support.annotation.RequiresApi;
import android.support.v4.app.FragmentManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;

@RequiresApi(api = Build.VERSION_CODES.N)
public class MainActivity extends AppCompatActivity {




    BigDecimal itemsTotal = new BigDecimal("0");
    BigDecimal totalAmount = new BigDecimal("0");
    BigDecimal taxAmount = new BigDecimal("0");


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        FragmentManager fm = getSupportFragmentManager();
        fm.beginTransaction().replace(R.id.fragment_items, new ItemsFragment(), "ItemFrag")
                .replace(R.id.fragment_totals, new TotalsFragment(), "TotFrag")
                .replace(R.id.fragment_tax, new TaxFragment(), "TaxFrag")
                .commit();





    }

    public BigDecimal getItemsTotal()
    {
        return itemsTotal;
    }

    public void setTotalAmt()
    {
        this.totalAmount = this.itemsTotal.add(this.taxAmount);
        TotalsFragment totalFrag = (TotalsFragment) getSupportFragmentManager().findFragmentByTag("TotFrag");
        if(totalFrag != null){
            totalFrag.setTotalAmount(totalAmount);
        }

    }

    public void setTaxAmount(BigDecimal taxAmount)
    {
        this.taxAmount = taxAmount;
        setTotalAmt();

    }


    public void setItemsTotal(BigDecimal itemsTotals)
    {
        itemsTotal = itemsTotals;
        setTotalAmt();

    }



    @Override
    public void onStart() {
        super.onStart();
        Log.d(getClass().getSimpleName(), "onStart()");
    }


    @Override
    public void onPause() {

        super.onPause();
        Log.d(getClass().getSimpleName(), "onPause()");

    }

    @Override
    public void onStop() {
        Log.d(getClass().getSimpleName(), "onStop()");
        super.onStop();
    }


    @Override
    public void onDestroy() {
        Log.d(getClass().getSimpleName(), "onDestroy()");
        super.onDestroy();
    }



    @Override
    protected void onResume() {
        super.onResume();

        Log.d(getClass().getSimpleName(), "onResume()");






    }



}
