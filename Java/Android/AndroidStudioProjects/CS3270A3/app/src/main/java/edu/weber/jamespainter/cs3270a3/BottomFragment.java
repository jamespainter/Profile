package edu.weber.jamespainter.cs3270a3;



import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.text.Editable;
import android.text.TextWatcher;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import android.widget.TextView;
import android.widget.Toast;

import java.util.Objects;


/**
 * A simple {@link Fragment} subclass.
 */
public class BottomFragment extends Fragment  {

    private View rootView;
    private TextView tv_phone_score;
    private TextView tv_myscore;
    private int phoneScore;
    private int myScore;
    private int myScoreCount=0;
    private int phoneCount=0;
    public BottomFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_bottom, container, false);




        return rootView;
    }

    public void PhoneScore()
    {
        phoneScore++;

        tv_phone_score = (TextView) rootView.findViewById(R.id.phone_score);
        tv_phone_score.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {


            }

            @Override
            public void afterTextChanged(Editable s) {
                if(phoneScore ==4) {
                    Toast toast = Toast.makeText(getActivity(), "The Phone score is 4. It needs 1 point to Win!", Toast.LENGTH_SHORT);
                    toast.show();
                }
                if(phoneScore == 5)
                {
                    phoneCount++;
                    if(phoneCount ==1) {
                        YesNoFragment dialog = new YesNoFragment();
                        dialog.setCancelable(false);
                        dialog.show(getFragmentManager(), "Question");
                    }
                }
            }
        });
        tv_phone_score.setText(Integer.toString(phoneScore));

    }
    public void myScore()
    {

        myScore++;
        tv_myscore = (TextView) rootView.findViewById(R.id.my_score);
        tv_myscore.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {


        }

            @Override
            public void afterTextChanged(Editable s) {
                if(myScore ==4) {
                    Toast toast = Toast.makeText(getActivity(), "Your score is 4. You need 1 point to Win!", Toast.LENGTH_SHORT);
                    toast.show();
                }
                if(myScore == 5)
                {
                    myScoreCount++;
                    if(myScoreCount ==1) {
                        YesNoFragment dialog = new YesNoFragment();
                        dialog.setCancelable(false);
                        dialog.show(getFragmentManager(), "Question");

                    }
                }
            }
        });


        tv_myscore.setText(Integer.toString(myScore));

    }

    public void resetFinish(String message)
    {
        if(Objects.equals(message, "Yes"))
        {
            phoneScore =0;
            myScore = 0;
            tv_myscore.setText("0");
            tv_phone_score.setText("0");
            myScoreCount =0;
            phoneCount =0;
        }
        else {
            Toast toast = Toast.makeText(getActivity(), "Thank you for Playing!", Toast.LENGTH_SHORT);
            toast.show();
            getActivity().finish();
        }

    }


}


