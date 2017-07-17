package edu.weber.jamespainter.cs3270a7;


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
public class AreYouSureFragment extends DialogFragment {


    public AreYouSureFragment() {
        // Required empty public constructor
    }


    @NonNull
    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        AlertDialog.Builder builder = new AlertDialog.Builder(getActivity());

        return builder.setMessage("This will permanently delete")
                .setCancelable(true)
                .setTitle("Are You Sure?")
                .setPositiveButton("Yes", new DialogInterface.OnClickListener(){
                    public void onClick(DialogInterface dialog1, int id)
                    {
                        MainActivity maF = (MainActivity) getActivity();
                        if(maF != null)
                            maF.setDecision("Yes");
                    }

                })
                .setNegativeButton("No", new DialogInterface.OnClickListener(){
                    public void onClick(DialogInterface dialog1, int id)
                    {
                        MainActivity maF = (MainActivity) getActivity();
                        if(maF != null)
                            maF.setDecision("No");

                    }
                }).create();
    }


}
