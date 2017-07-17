package edu.weber.jamespainter.cs3270a5;

import android.app.FragmentManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Layout;
import android.view.Menu;
import android.view.MenuItem;

public class MainActivity extends AppCompatActivity {

    float change_total_so_far_total = 0;
    int correct_change_count = 0;

    ChangeResults cr;
    ChangeButtons cb;
    ChangeActions ca;
    MaxAmountFragment mf;

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        getMenuInflater().inflate(R.menu.main_menu, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
//

        int id = item.getItemId();
        if(id == R.id.action_set_change_max){
            getSupportFragmentManager().beginTransaction().add(R.id.fragment_change_Results, new MaxAmountFragment(), "ma").commit();

            cr = (ChangeResults) getSupportFragmentManager().findFragmentByTag("cr");
            android.support.v4.app.FragmentManager fragmentManager = getSupportFragmentManager();
            fragmentManager.beginTransaction().hide(cr).commit();

            cb = (ChangeButtons) getSupportFragmentManager().findFragmentByTag("cb");
            fragmentManager.beginTransaction().hide(cb).commit();

            ca = (ChangeActions) getSupportFragmentManager().findFragmentByTag("ca");
            fragmentManager.beginTransaction().hide(ca).commit();

            mf = (MaxAmountFragment) getSupportFragmentManager().findFragmentByTag("ma");



            return true;
        }
        if(id == R.id.action_zero_correct_Count){
            ChangeActions zero_correct_count = (ChangeActions) getSupportFragmentManager().findFragmentByTag("ca");
            if(zero_correct_count != null) {
                //Call method zero Correct count in Change Actions Fragment
                zero_correct_count.zero_correct_Count();
                return true;
            }

        }
        return super.onOptionsItemSelected(item);
    }



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_change_Results, new ChangeResults(), "cr").commit();
        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_change_buttons, new ChangeButtons(), "cb").commit();
        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_change_actions, new ChangeActions(), "ca").commit();

    }
//ChangeResults
    public void addChangeSoFarTotal(float changeSoFarTotal)
    {

        change_total_so_far_total += changeSoFarTotal;
        ChangeResults ChangeFarTotal = (ChangeResults) getSupportFragmentManager().findFragmentByTag("cr");
        if(ChangeFarTotal != null)
        {
            ChangeFarTotal.setChangeTotalSoFar(change_total_so_far_total);

        }

    }

    public float getChangeSoFarTotal()
    {

        return change_total_so_far_total;

    }
//ChangeResult Main Activity call to change Change total so far total edit text
    public void starNewResetChangeSoFarTotal()
    {
        ChangeResults resetGameResults = (ChangeResults) getSupportFragmentManager().findFragmentByTag("cr");
        if(resetGameResults != null)
        {
            //make call to ChangeResults to reset Results
            resetGameResults.resetChangeTotalSoFar();
            change_total_so_far_total = 0f;

        }

    }
//ChangeResult Main Activity call to set a new amount for EditText changeTotal
    public void newAmount(){

        ChangeResults setNewAmount = (ChangeResults) getSupportFragmentManager().findFragmentByTag("cr");
        if(setNewAmount != null){

            setNewAmount.newAmount();

        }


    }
//ChangeAction Main Activity call to increment Correct Change Count
    public void addCorrectChangeCount() {
        correct_change_count++;
        ChangeActions setCorrectChangeCount = (ChangeActions) getSupportFragmentManager().findFragmentByTag("ca");
        if (setCorrectChangeCount != null) {
            //Make call to ChangeActions to set et_Correct_Change_Count
            setCorrectChangeCount.setCorrectChangeCount(correct_change_count);
        }


    }

// Call too long dialog
    public void showTooLongDialog()
    {

        TooLongDia dialog = new TooLongDia();
        dialog.setCancelable(false);
        dialog.show(getSupportFragmentManager(), "Question");

    }
// Call You did it dialog
    public void showYouDidItDialog(){


        YouDidItDia dialog = new YouDidItDia();
        dialog.setCancelable(false);
        dialog.show(getSupportFragmentManager(), "Question");


    }
//Call That's too much change
    public void showTooMuchChange(){

        TooHighDia dialog = new TooHighDia();
        dialog.setCancelable(false);
        dialog.show(getSupportFragmentManager(), "Question");

    }

//Method Call to change Results to set/save max count;
    public void setMaxCount(float count)
    {
        ChangeResults setMaxCountRand = (ChangeResults) getSupportFragmentManager().findFragmentByTag("cr");
        if(setMaxCountRand != null)
        {
            //pass count to set max count in change results fragment
            setMaxCountRand.setMaxAmount(count);

        }


    }

// Max Amount Fragment
    public void hideMaxAmountFrag()
    {


        android.support.v4.app.FragmentManager fragmentManager = getSupportFragmentManager();
        fragmentManager.beginTransaction().show(cr).commit();


        fragmentManager.beginTransaction().show(cb).commit();


        fragmentManager.beginTransaction().show(ca).commit();

        mf = (MaxAmountFragment) getSupportFragmentManager().findFragmentByTag("ma");
        fragmentManager.beginTransaction().hide(mf).commit();

    }



}
