package edu.weber.jamespainter.week5examples;


import android.content.SharedPreferences;
import android.os.Bundle;
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


/**
 * A simple {@link Fragment} subclass.
 */
public class MainFragment extends Fragment {

    TextView tv_helloWorld;
    EditText et_message;
    Button  btn_SetText;
    public MainFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_main, container, false);
        tv_helloWorld = (TextView) rootView.findViewById(R.id.tv_hello_World);
        tv_helloWorld.setText("Hello WORLD!");

        et_message = (EditText) rootView.findViewById(R.id.et_message);

        btn_SetText = (Button) rootView.findViewById(R.id.bt_Set_Text);

         btn_SetText.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View v) {
                 et_message.setText("Message");
                 tv_helloWorld.setText("SharedPreferences");
                 tv_helloWorld.setTextColor(3);
             }
         });

        return rootView;
    }




    @Override
    public void onPause() {
        super.onPause();
        Log.d("text", "Main Fragment onPause");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putString("tv_message", tv_helloWorld.getText().toString());
        editor.putString("et_message", et_message.getText().toString());
        editor.putInt("sv_color", tv_helloWorld.getCurrentTextColor());
        editor.apply();

    }

    @Override
    public void onResume() {
        super.onResume();
        Log.d("text", "Main Fragment onResume");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        tv_helloWorld.setText(prefs.getString("tv_message", "Hello World!"));
        et_message.setText(prefs.getString("et_message",""));
        tv_helloWorld.setTextColor(prefs.getInt("sv_color", 0xFF000000));
    }
}
