package edu.weber.jamespainter.cs3270a5;


import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v4.app.DialogFragment;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;


/**
 * A simple {@link Fragment} subclass.
 */
public class TooLongDia extends DialogFragment {


    public TooLongDia() {
        // Required empty public constructor
    }


    @NonNull
    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {
        // Inflate the layout for this fragment


        AlertDialog.Builder builder = new AlertDialog.Builder(getActivity());
// Add the buttons
//        builder.setPositiveButton(R.string.ok, new DialogInterface.OnClickListener() {
//            public void onClick(DialogInterface dialog, int id) {
//                // User clicked OK button
//            }
//        });
       // AlertDialog dialog = builder.create();
        //return dialog;


        return builder.setMessage("You should play again.")
                .setCancelable(false)
                .setTitle("You Took to long")
                .setPositiveButton("ok", new DialogInterface.OnClickListener(){
                    public void onClick(DialogInterface dialog1, int id)
                    {

                    }

                }).create();


    }

}
