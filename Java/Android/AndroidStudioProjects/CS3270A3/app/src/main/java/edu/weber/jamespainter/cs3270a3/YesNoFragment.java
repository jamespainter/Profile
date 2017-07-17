package edu.weber.jamespainter.cs3270a3;


import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v4.app.DialogFragment;
import android.support.v4.app.Fragment;



/**
 * A simple {@link Fragment} subclass.
 */
public class YesNoFragment extends DialogFragment {


    public YesNoFragment() {
        // Required empty public constructor
    }


    @NonNull
    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        AlertDialog.Builder builder = new AlertDialog.Builder(getActivity());

        return builder.setMessage("Would you like to start over?")
        .setCancelable(false)
        .setTitle("Play Again?")
        .setPositiveButton("Yes", new DialogInterface.OnClickListener(){
            public void onClick(DialogInterface dialog1, int id)
            {
                MainActivity maF = (MainActivity) getActivity();
                maF.MessageFromFragment("Yes");
            }

        })
        .setNegativeButton("No", new DialogInterface.OnClickListener(){
            public void onClick(DialogInterface dialog1, int id)
            {
                MainActivity maF = (MainActivity) getActivity();
                maF.MessageFromFragment("NO");

            }
        }).create();
    }

}
