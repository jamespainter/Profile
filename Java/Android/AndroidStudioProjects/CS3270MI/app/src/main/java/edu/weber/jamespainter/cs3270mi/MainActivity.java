package edu.weber.jamespainter.cs3270mi;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_action, new ActionFragment(), "af").commit();
        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_results, new ResultsFragment(), "rf").commit();

    }


    public void setBodyEval(double BMI, Double BFP)
    {

        ResultsFragment rf = (ResultsFragment) getSupportFragmentManager().findFragmentByTag("rf");
        if(rf != null)
        {
            rf.setBMIAndBFP(BMI, BFP);
        }






    }






}
