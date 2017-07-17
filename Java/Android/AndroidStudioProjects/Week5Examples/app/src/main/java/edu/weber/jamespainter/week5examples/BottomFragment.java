package edu.weber.jamespainter.week5examples;


import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;


/**
 * A simple {@link Fragment} subclass.
 */
public class BottomFragment extends Fragment {


    EditText ed_FirstName;
    EditText ed_LastName;
    EditText ed_Email;

    public BottomFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_bottom, container, false);
        ed_FirstName = (EditText) rootView.findViewById(R.id.et_FirstName);
        ed_LastName = (EditText) rootView.findViewById(R.id.et_LastName);
        ed_Email = (EditText) rootView.findViewById(R.id.et_Email);

        return rootView;
    }

    public void clearfields()
    {
        ed_FirstName.setText("");
        ed_LastName.setText("");
        ed_Email.setText("");

    }


    @Override
    public void onResume() {
        super.onResume();
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        ed_FirstName.setText(prefs.getString("et_FirstName", "Hello World!"));
        ed_LastName.setText(prefs.getString("et_message",""));
        ed_Email.setText(prefs.getString("et_Email",""));
    }

    @Override
    public void onPause() {
        super.onPause();
        Log.d("text", "Main Fragment onPause");
        SharedPreferences prefs = getActivity().getPreferences(getActivity().MODE_PRIVATE);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putString("et_FirstName", ed_FirstName.getText().toString());
        editor.putString("et_LastName", ed_LastName.getText().toString());
        editor.putString("et_Email", ed_Email.getText().toString());
        editor.apply();
    }
}
