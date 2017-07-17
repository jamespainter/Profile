package edu.weber.jamespainter.cs3270a5;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.view.View.OnClickListener;

/**
 * A simple {@link Fragment} subclass.
 */
public class MaxAmountFragment extends Fragment implements OnClickListener{

    View rootView;
    EditText et_set_max_amount;
    Button btn_save;

    public MaxAmountFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_max_amount, container, false);
        et_set_max_amount = (EditText) rootView.findViewById(R.id.et_set_max_amount);
        btn_save = (Button) rootView.findViewById(R.id.btn_save);
        btn_save.setOnClickListener(this);

        return rootView;
    }
    public void onClick(View v)
    {
        MainActivity ma = (MainActivity) getActivity();
        if(ma != null)
        {
            //set Max Count
            try{
                ma.setMaxCount(Float.valueOf(et_set_max_amount.getText().toString()));
                ma.hideMaxAmountFrag();
            }
            catch(Exception e)
            {
                System.out.println(e.toString());
            }
        }


    }
}
