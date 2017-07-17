package edu.weber.jamespainter.cs3270a5;


import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.view.View.OnClickListener;

/**
 * A simple {@link Fragment} subclass.
 */
public class ChangeActions extends Fragment implements OnClickListener {

    View rootView;
    Button btn_start_over;
    Button btn_new_amount;
    EditText et_correct_change_count;

    public ChangeActions() {
        // Required empty public constructor
    }

    @Override
    public void onResume() {
        super.onResume();
        Log.d("text", "Main Fragment onResume");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        et_correct_change_count.setText(prefs.getString("et_message","0"));
    }

    @Override
    public void onPause() {
        super.onPause();
        Log.d("text", "ChangeActions onPause");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putString("et_correct_change_count", et_correct_change_count.getText().toString());
        editor.apply();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_change_actions, container, false);

        btn_start_over = (Button) rootView.findViewById(R.id.btn_start_over);
        btn_start_over.setOnClickListener(this);
        btn_new_amount = (Button) rootView.findViewById(R.id.btn_new_amount);
        btn_new_amount.setOnClickListener(this);
        et_correct_change_count = (EditText) rootView.findViewById(R.id.et_correct_change_count);



        return rootView;
    }
    public void onClick(View v)
    {
        MainActivity ma = (MainActivity) getActivity();

        switch (v.getId())
        {
            case R.id.btn_start_over :
                if(ma != null)
                {
                    ma.starNewResetChangeSoFarTotal();

                }
                break;
            case R.id.btn_new_amount :
                if(ma != null)
                {
                    ma.newAmount();
                }
                break;


        }
    }
//Set et_correct_change_count text
    public void setCorrectChangeCount(int count)
    {
        et_correct_change_count.setText(String.valueOf(count));
    }
//Zero out the correct change count
    public void zero_correct_Count()
    {
        et_correct_change_count.setText(String.valueOf(0));

    }



}
