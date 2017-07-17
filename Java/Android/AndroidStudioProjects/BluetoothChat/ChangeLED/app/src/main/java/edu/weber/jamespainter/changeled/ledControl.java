package edu.weber.jamespainter.changeled;

import android.app.Notification;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.bluetooth.BluetoothSocket;
import android.content.Intent;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.Toast;
import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.os.AsyncTask;
import java.io.IOException;
import java.util.UUID;



public class ledControl extends AppCompatActivity {

    Button btn_led_on, btn_led_off,btn_disconnect;
    SeekBar brightness;
    TextView tv_indicator;
    String address;
    private ProgressDialog progress;
    BluetoothAdapter myBluetooth = null;
    BluetoothSocket btSocket = null;
    boolean isBtConnected = false;
    static final UUID myUUID = UUID.fromString("00001101-0000-1000-8000-00805F9B34FB");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_led_control);

        Intent newint = getIntent();
        address = newint.getStringExtra(DeviceList.EXTRA_ADDRESS);

        //view of the ledControl layout
        setContentView(R.layout.activity_led_control);

        btn_led_on = (Button) findViewById(R.id.btn_led_on);
        btn_led_off = (Button) findViewById(R.id.btn_led_off);
        btn_disconnect = (Button) findViewById(R.id.btn_disconnect);
        brightness = (SeekBar) findViewById(R.id.sb_brightness);
        tv_indicator = (TextView) findViewById(R.id.tv_indicator);

        //New AsyncTask/Thread
        new ConnectBT().execute();

        //Turn ON LED on click event
        btn_led_on.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                turnOnLed();
            }
        });
        //Turn OFF LED on Click Event
        btn_led_off.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                turnOffLed();
            }
        });
        //Close BluetoothConnection
        btn_disconnect.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                disconnect();
            }
        });
        //SeekBar to change the brightness from low to high
        brightness.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                if (fromUser == true) {
                    tv_indicator.setText(String.valueOf(progress));
                    try {
                        btSocket.getOutputStream().write((String.valueOf(progress)+":").getBytes());
                    } catch (IOException e) {
                        System.out.println(e.toString());
                    }
                }
            }
            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {


            }
        });
    }
    //Method Message to show toast of errors or successes of connections
    private void message(String s)
    {
        Toast.makeText(getApplicationContext(),s,Toast.LENGTH_LONG).show();
    }
    //Disconnect Method that will disconnect the Bluetooth connection through the socket
    private void disconnect()
    {
        if (btSocket!=null) //If the btSocket is busy
        {
            try
            {
                btSocket.close(); //close connection
            }
            catch (IOException e)
            {
                message("Error");
            }
        }
        finish(); //return to the first layout
    }
    //turnOn Method turns LED on Arduino board
    private void turnOnLed()
    {
        if (btSocket!=null)
        {
            try
            {

                btSocket.getOutputStream().write("TO:".toString().getBytes());
            }
            catch (IOException e)
            {
                message("Error");
            }
        }
    }
    //turnOffLed Method turn LED light on Arduino board
    private void turnOffLed()
    {
        //checks to see if the btSocket has no value
        if (btSocket!= null)
        {
            try
            {
                btSocket.getOutputStream().write("TF:".toString().getBytes());
            }
            catch (IOException e)
            {
                message("Error");
            }
        }
    }
    //onPreExecute, doInBackground, onPostExecute for a single thread
    private class ConnectBT extends AsyncTask<Void, Void, Void> // UI thread
    {
        private boolean ConnectSuccess = true; //if its here, its almost connected

        @Override
        protected void onPreExecute() {
            progress = ProgressDialog.show(ledControl.this, "Connecting...", "Please Wait!!!"); // show a progress dialog
        }

        @Override
        protected Void doInBackground(Void... params) {
            try{

                if(btSocket == null)
                {
                    if(!isBtConnected)
                    {
                        myBluetooth = BluetoothAdapter.getDefaultAdapter();
                        //connects to the devices address and checks if it's available
                        BluetoothDevice device = myBluetooth.getRemoteDevice(address);
                        btSocket = device.createInsecureRfcommSocketToServiceRecord(myUUID);
                        BluetoothAdapter.getDefaultAdapter().cancelDiscovery();
                        btSocket.connect();//start connection
                    }
                }

            }
            catch (IOException e)
            {
                ConnectSuccess = false;
            }
            return null;
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            super.onPostExecute(aVoid);

            if(!ConnectSuccess)
            {
                message("Connection Failed. Is it a SPP Bluetooth? Try Again.");
                finish();
            }
            else
            {
                message("Connected...");
                isBtConnected = true;

            }
            progress.dismiss();

        }
    }

}
