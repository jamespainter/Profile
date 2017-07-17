package edu.weber.jamespainter.mathlete;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Toast;


/**
 * A simple {@link Fragment} subclass.
 */
public class Login extends Fragment {
    View rootView;
    Button btn_Login;
    EditText et_Username;
    EditText et_Password;
    LinearLayout l_lf;
    LinearLayout l_mf;
    public Login() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView =  inflater.inflate(R.layout.fragment_login, container, false);

        btn_Login = (Button) rootView.findViewById(R.id.btn_login);
        et_Username = (EditText) rootView.findViewById(R.id.et_username);
        et_Password =  (EditText) rootView.findViewById(R.id.et_password);
        l_lf = (LinearLayout) rootView.findViewById(R.id.fragment_login);
        l_mf = (LinearLayout) rootView.findViewById(R.id.fragment_module);

        btn_Login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DatabaseHelper dbHelper = new DatabaseHelper(getActivity(), "Classes", null, 1 );
                boolean isUser = dbHelper.checkUser(et_Username.getText().toString(), et_Password.getText().toString());
                MainActivity ma = (MainActivity) getActivity();
                if(isUser)
                {
                    if(ma != null)
                    {
                        ma.ShowModuleFragment();
                    }
                    else
                    {
                        Toast.makeText(getActivity().getBaseContext(), "Cannot find User", Toast.LENGTH_SHORT).show();
                    }

                }
            }
        });

        return rootView;


    }

}
