package edu.weber.jamespainter.cs3270mi;


import android.os.Bundle;
import android.provider.MediaStore;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

import org.w3c.dom.Text;


/**
 * A simple {@link Fragment} subclass.
 */
public class ActionFragment extends Fragment {


    TextView tv_weight_in_pounds;
    EditText et_weight_in_pounds;
    TextView tv_height_in_inches;
    EditText et_height_in_inches;
    TextView tv_age;
    EditText et_age;
    RadioButton rb_female;
    RadioButton rb_male;
    Button btn_calculate;

    View rootView;


    int male = 0;

    int female = 0;

    double body_mass_index = 0.0;
    double body_fat_percentate = 0.0;

    public ActionFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView =  inflater.inflate(R.layout.fragment_action, container, false);

        tv_weight_in_pounds = (TextView) rootView.findViewById(R.id.et_weight_in_pounds);
        et_weight_in_pounds = (EditText) rootView.findViewById(R.id.et_weight_in_pounds);
        tv_height_in_inches = (TextView) rootView.findViewById(R.id.tv_height_in_inches);
        et_height_in_inches = (EditText) rootView.findViewById(R.id.et_height_in_inches);
        tv_age = (TextView) rootView.findViewById(R.id.tv_age);
        et_age = (EditText) rootView.findViewById(R.id.et_age);
        rb_female = (RadioButton) rootView.findViewById(R.id.rb_female);
        rb_male = (RadioButton) rootView.findViewById(R.id.rb_male);
        btn_calculate = (Button) rootView.findViewById(R.id.btn_calculate);

        et_weight_in_pounds.setText("0");
        et_height_in_inches.setText("0");
        et_age.setText("0");

        rb_female.setChecked(true);
        female  = 1;
        rb_female.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                rb_female.setChecked(true);
                rb_male.setChecked(false);
                female = 1;
                male = 0;

            }
        });

        rb_male.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                rb_female.setChecked(false);
                rb_male.setChecked(true);
                female = 0;
                male = 1;
            }
        });


        btn_calculate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                double weight  = Double.valueOf(et_weight_in_pounds.getText().toString());
                double height  = Double.valueOf(et_height_in_inches.getText().toString());
                double age = Double.valueOf(et_age.getText().toString());
                MainActivity ma = (MainActivity) getActivity();
                if(female == 1)
                {
                    body_mass_index =  weight / Math.pow(height, 2) * 703;
                    body_fat_percentate = (1.20 * body_mass_index) + (0.23 * age) - (10.8 * 0) - 5.4;
                    if(ma != null)
                    {
                        ma.setBodyEval(body_mass_index, body_fat_percentate );


                    }


                }
                else if(male == 1)
                {

                    body_mass_index = weight / Math.pow(height, 2) * 703;
                    body_fat_percentate = (1.20 * body_mass_index) + (0.23 * age) - (10.8 * 1) - 5.4;

                    if(ma != null)
                    {
                        ma.setBodyEval(body_mass_index, body_fat_percentate );


                    }

                }
            }
        });





        return rootView;
    }

}
