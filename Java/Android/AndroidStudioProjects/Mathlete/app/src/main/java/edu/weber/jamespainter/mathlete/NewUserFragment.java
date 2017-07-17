package edu.weber.jamespainter.mathlete;


import android.icu.text.DateTimePatternGenerator;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;
import java.util.Date;

/**
 * A simple {@link Fragment} subclass.
 */
public class NewUserFragment extends Fragment {

    View rootView;
    ImageButton btn_save;
    EditText et_enter_username;
    EditText et_enter_password;


    public NewUserFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
       rootView =  inflater.inflate(R.layout.fragment_new_user, container, false);





       btn_save = (ImageButton) rootView.findViewById(R.id.btn_save);
       et_enter_username = (EditText) rootView.findViewById(R.id.et_username);
       et_enter_password = (EditText) rootView.findViewById(R.id.et_enter_password);
       ///click on save to save the new user to the database
       btn_save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Date date = new Date();
                int userID = 0;
                if(et_enter_username.getText().toString() != "")
                {
                    if(et_enter_password.getText().toString() != "")
                    {
                        userID++;
                        DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1 );
                        long row = dbHelper.insertUser(et_enter_username.getText().toString(), et_enter_password.getText().toString(), date.toString(), date.toString());
                    }
                }
                else
                {
                    Toast.makeText(getActivity().getBaseContext(), "Enter UserName", Toast.LENGTH_SHORT).show();
                }


            }
        });

       return rootView;
    }

}
