package edu.weber.jamespainter.bluetooth;

import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    ProgressDialog mProgressDig;
    private static final int REQUEST_ENABLE_BT=1;
    TextView onBtn;
    TextView offBtn;
    TextView text;
    TextView discover;
    BluetoothAdapter mBlueToothAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        text = (TextView) findViewById(R.id.text);
        onBtn =(TextView) findViewById(R.id.btn_connectDevice);
        offBtn =(TextView) findViewById(R.id.btn_DisconnectDevice);
        discover = (TextView) findViewById(R.id.btn_Discoverable);
        mBlueToothAdapter = BluetoothAdapter.getDefaultAdapter();
        mProgressDig = new ProgressDialog(this);
        mProgressDig.setMessage("...Scanning");

        mProgressDig.setButton(DialogInterface.BUTTON_NEGATIVE, "Cancel", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });

        discover.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                makeDiscoverable();
            }
        });

        if(mBlueToothAdapter == null)
        {
            showUnsupported();
        }
        else {

            if(mBlueToothAdapter.isEnabled())
            {
                showEnabled();
            }
            else {
                showDisabled();
            }

            onBtn.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent turnOnIntent= new Intent(BluetoothAdapter.ACTION_REQUEST_ENABLE);
                    startActivityForResult(turnOnIntent, REQUEST_ENABLE_BT);
                }
            });

            offBtn.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    mBlueToothAdapter.disable();
                    showDisabled();
                }
            });
        }

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if(requestCode == REQUEST_ENABLE_BT)
        {
            if(mBlueToothAdapter.isEnabled())
            {
                showEnabled();
            }
            else {
                showDisabled();
            }
        }
    }

    private void showEnabled(){

        text.setText("Bluetooth is On");
        text.setTextColor(Color.BLUE);
        offBtn.setEnabled(true);
        onBtn.setEnabled(false);

    }

    private void showDisabled() {

        text.setText("Bluetooth is Off");
        text.setTextColor(Color.RED);
        offBtn.setEnabled(false);
        onBtn.setEnabled(true);

    }

    private void showUnsupported()
    {
        text.setText("Bluetooth is unsupported by this Device");
    }

    private void makeDiscoverable(){

        Intent discoverableIntent = new Intent(BluetoothAdapter.ACTION_REQUEST_DISCOVERABLE);
        discoverableIntent.putExtra(BluetoothAdapter.EXTRA_DISCOVERABLE_DURATION, 300);
        startActivity(discoverableIntent);

    }


}
