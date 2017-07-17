package edu.weber.jamespainter.zombiepack;


import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothClass;
import android.bluetooth.BluetoothDevice;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;


/**
 * A simple {@link Fragment} subclass.
 */
public class BluetoothFragment extends Fragment {


    Button btn_connectDevice;
    Button btn_DisconnectDevice;
    Button btn_Discoverable;

    ProgressDialog mProgressD;
    private static final int REQUEST_ENABLE_BT =1;
    BluetoothAdapter bt_Adaptor;


    View rootView;

    public BluetoothFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        rootView = inflater.inflate(R.layout.fragment_bluetooth, container, false);

        btn_connectDevice = (Button) rootView.findViewById(R.id.btn_connectDevice);
        btn_DisconnectDevice = (Button) rootView.findViewById(R.id.btn_DisconnectDevice);
        btn_Discoverable = (Button) rootView.findViewById(R.id.btn_Discoverable);

        ///mProgressD = new ProgressDialog();


        return rootView;

    }

}
