package edu.weber.jamespainter.zombiepack;

import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothClass;
import android.bluetooth.BluetoothDevice;
import android.content.DialogInterface;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import static android.content.DialogInterface.*;

public class MainActivity extends AppCompatActivity {

    ProgressDialog mProgressD;
    BluetoothAdapter myBlootoohAdapter;
    private static final int REQUEST_ENABLE_BT=1;


    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
            getSupportFragmentManager().beginTransaction().add(R.id.frag_bluetooth, new BluetoothFragment(), "bf").commit();

        mProgressD = new ProgressDialog(this);
        mProgressD.setMessage("Scanning..");
        mProgressD.setButton(BUTTON_NEGATIVE, "Cancel", new DialogInterface.OnCancelListener() {
            @Override
            public void onCancel(DialogInterface dialog) {
                dialog.dismiss();
            }
        });

    }

    private void showEnabled() {



    }

}
