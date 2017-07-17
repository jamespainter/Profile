package edu.weber.jamespainter.changeled;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import java.util.Set;
import java.util.ArrayList;
import android.widget.Toast;
import android.widget.ArrayAdapter;
import android.widget.AdapterView;
//import android.widget.AdapterView.OnClickListener;
import android.widget.TextView;
import android.content.Intent;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import org.w3c.dom.Text;

public class DeviceList extends AppCompatActivity {
    TextView tv_hint;
    Button btn_pairing;
    ListView lv_paired_devices;
    private BluetoothAdapter myBluetooth = null;
    private Set pairedDevices;
    public static String EXTRA_ADDRESS = "device_address";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_device_list);


        tv_hint = (TextView) findViewById(R.id.tv_hint);
        btn_pairing = (Button) findViewById(R.id.btn_pairing);
        lv_paired_devices = (ListView) findViewById(R.id.lv_paired_devices);


        myBluetooth = BluetoothAdapter.getDefaultAdapter();
        if(myBluetooth == null)
        {
            //Show a message that the device has no bluetooth adapter
            Toast.makeText(getApplicationContext(), "Bluetooth Device Not Available", Toast.LENGTH_LONG).show();
            //finish apk
            finish();
        }
        else
        {
            if(myBluetooth.isEnabled())
            {

            }
            else
            {
                //Ask to the user turn the bluetooth on
                Intent turnBTon = new Intent(BluetoothAdapter.ACTION_REQUEST_ENABLE);
                startActivityForResult(turnBTon,1);
            }
        }

        btn_pairing.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                pairedDevicesList(); //method that will be called
            }
        });

    }

    private void pairedDevicesList()
    {
        pairedDevices = myBluetooth.getBondedDevices();
        ArrayList list = new ArrayList();

        if(pairedDevices.size()>0)
        {
            for(Object bt : pairedDevices)
            {
                BluetoothDevice bi = (BluetoothDevice)bt;
                list.add(bi.getName() + "\n" + bi.getAddress());
            }
        }
        else
        {
            Toast.makeText(getApplicationContext(), "No Paired Bluetooth Devices Found", Toast.LENGTH_LONG).show();
        }

        final ArrayAdapter adapter = new ArrayAdapter(this, android.R.layout.simple_expandable_list_item_1, list);
        lv_paired_devices.setAdapter(adapter);
        lv_paired_devices.setOnItemClickListener(myListClickListener); //Method called when the device from the list is clicked
    }

    private AdapterView.OnItemClickListener myListClickListener = new AdapterView.OnItemClickListener()
    {
      public void onItemClick (AdapterView av, View v, int arg2, long arg3)
      {
          // Get the device MAC address, the last 17 chars in the View
          String info = ((TextView)v).getText().toString();
          String address = info.substring(info.length()-17);
          //Make an intent to start next activity.
          Intent i = new Intent(DeviceList.this, ledControl.class);
          //change the activity.
          i.putExtra(EXTRA_ADDRESS, address); // this will be received at ledControl (class) Activity
          startActivity(i);
      }
    };
}
