package edu.weber.jamespainter.cs3270a5;


import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.icu.math.BigDecimal;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.support.v4.app.Fragment;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.view.View.OnClickListener;
import org.w3c.dom.Text;
import java.lang.Math;
import java.util.Random;
import java.util.concurrent.TimeUnit;

import static java.lang.StrictMath.toIntExact;

//implements OnClickListener
/**
 * A simple {@link Fragment} subclass.
 */
public class ChangeResults extends Fragment implements OnClickListener{

//Objects
    View rootView;
    EditText et_change_to_make;
    EditText et_change_total_so_far;
    EditText et_time_remaining;

//Totals
    BigDecimal bd_change_to_make;
    BigDecimal bd_change_total_so_far;

//CountDownTimer
    private final long startTime = 15000;
    private final long interval = 1000;
    Timer timer;
    Button time;

    private boolean timerHasStarted = false;

//Change To Make
    Random random;
    float min = 0.0f;
    float max = 100.0f;


    public ChangeResults() {
        // Required empty public constructor
    }

    @Override
    public void onResume() {
        super.onResume();
        Log.d("text", "Main Fragment onResume");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        try{
            et_change_total_so_far.setText(prefs.getString("et_change_total_so_far", "$.00"));
        }
        catch (Exception e)
        {
            System.out.println(e.toString());
        }
        et_change_to_make.setText(prefs.getString("et_change_to_make","$24.67"));
    }

    @Override
    public void onPause() {
        super.onPause();
        Log.d("text", "ChangeActions onPause");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putString("et_change_to_make", et_change_to_make.getText().toString());
       try {
           int index2 = et_change_total_so_far.getText().toString().indexOf("$");
           String et_change_total_so_far_str_result = et_change_total_so_far.getText().toString().substring(index2+1);
           editor.putString("et_change_total_so_far", et_change_total_so_far.getText().toString());
       }
       catch(Exception e)
       {
           System.out.println(e.toString());
       }
        editor.apply();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_change_results, container, false);

        et_change_to_make = (EditText) rootView.findViewById(R.id.et_change_to_make);
        et_change_total_so_far = (EditText) rootView.findViewById(R.id.et_change_total_so_far);
        et_time_remaining = (EditText) rootView.findViewById(R.id.et_time_remaining);

     //   timer = new Timer(startTime, interval);
        startTimer();


//        //Start Timer From Click
//        time =  (Button) rootView.findViewById(R.id.btn_time);
//        time.setOnClickListener(this);

// Get randome Change to make amount when it first starts
        et_change_to_make.setText(String.format("$%.2f", randomFloat(min,max)));

//Value Change listener to see if change_total_so_far is to high
        et_change_total_so_far.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {

            }

            @Override
            public void afterTextChanged(Editable s) {

                int index1 = et_change_to_make.getText().toString().indexOf("$");
                String et_change_to_make_str_result = et_change_to_make.getText().toString().substring(index1+1);

                int index2 = et_change_total_so_far.getText().toString().indexOf("$");
                String et_change_total_so_far_str_result = et_change_total_so_far.getText().toString().substring(index2+1);

                try{
                    if(Float.valueOf(et_change_to_make_str_result) < Float.valueOf(et_change_total_so_far_str_result))
                    {
                        //Dialog to say user is to high
                        MainActivity ma = (MainActivity) getActivity();
                        if(ma != null)
                        {
                            //Increase Correct count in ChangeActionsFragment
                            ma.showTooMuchChange();

                        }

                    }
                }
                catch (Exception e)
                {
                    System.out.println(e.toString());
                }

            }
        });


        return rootView;
    }

 // set Max Number
    public void setMaxAmount(float maxAmount){

        max = maxAmount;



    }

 // add Correct Amount
    public void setCorrectChangeCount()
    {
        MainActivity ma = (MainActivity) getActivity();
        if(ma != null)
        {
            //Increase Correct count in ChangeActionsFragment
            ma.addCorrectChangeCount();

        }
    }


    //Change Change total so far
    public void setChangeTotalSoFar(float changeTotalSoFar)
    {
         et_change_total_so_far.setText(String.format("$%.2f", changeTotalSoFar));

    }
    // Start over and Reset Total so far
    public void resetChangeTotalSoFar(){

        et_change_total_so_far.setText("$.00");
        startTimer();

    }
    //set new amount
    public void newAmount(){

        et_change_to_make.setText(String.format("$%.2f", randomFloat(min,max)));
        startTimer();
    }


    //click if I need it
    public void onClick(View v)
    {
        if(!timerHasStarted) {
            timer.start();
            timerHasStarted = true;
        }

    }
    public void startTimer()
    {
        try {
            timer.cancel();
        }
        catch (Exception e)
        {
            System.out.println(e.toString());
        }
        timer = new Timer(startTime, interval);
        timer.start();
    }
    public float randomFloat(float min, float max)
    {

        random = new Random();
        return random.nextFloat() * (max - min) + min;

    }

    public class Timer extends CountDownTimer
    {

            public Timer(long startTime, long interval )
            {
                super(startTime,interval);


            }

        @Override
        public void onFinish() {
            et_time_remaining.setText("0");
            if(et_change_to_make.getText().toString().equals(et_change_total_so_far.getText().toString()))
            {
                MainActivity ma = (MainActivity) getActivity();
                if(ma != null)
                {
                    //Increase Correct count in ChangeActionsFragment
                    ma.addCorrectChangeCount();
                    ma.showYouDidItDialog();
                }

            }
            else{
                //Dialog  to say you took too long
                MainActivity ma = (MainActivity) getActivity();
                if(ma != null)
                {
                    //Increase Correct count in ChangeActionsFragment
                    ma.showTooLongDialog();

                }
            }
        }

        @Override
        public void onTick(long millisUntilFinished) {

            et_time_remaining.setText(""+String.format(" %d ",
                    TimeUnit.MILLISECONDS.toSeconds(millisUntilFinished) -
                            TimeUnit.MINUTES.toSeconds(TimeUnit.MILLISECONDS.toMinutes(millisUntilFinished))));



        }
    }
}


