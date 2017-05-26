package com.plummer.deric.teach_06;

import android.content.Context;
import android.os.AsyncTask;
import android.support.v7.view.menu.ListMenuPresenter;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.ProgressBar;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Deric on 5/24/17.
 */

public class LoadFileTask extends AsyncTask<Void, String, Void> {

    private String _fileName;
    private Context _context;
    private ArrayAdapter _aa;
    private ProgressBar _pb;

    public LoadFileTask(Context context, String fileName, ArrayAdapter aa, ProgressBar pb) {

        _fileName = fileName;
        _context = context;
        _aa = aa;
        _pb = pb;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();

    }

    @Override
    protected Void doInBackground(Void... params) {

        try(BufferedReader reader = new BufferedReader(new InputStreamReader(_context.openFileInput(_fileName)))) {

            String theString;
            while((theString = reader.readLine()) != null) {
                publishProgress(theString);
                Thread.sleep(250);
            }

        } catch (Exception e) {
            e.printStackTrace();
        }

//        try {
//            FileInputStream fis = _context.openFileInput(_fileName);
//            InputStreamReader isr = new InputStreamReader(fis, "UTF-8");
//            BufferedReader bufferedReader = new BufferedReader(isr);
//
//            String line;
//            while ((line = bufferedReader.readLine()) != null) {
//                publishProgress(line);
//            }
//
//        } catch (Exception e) {
//            Log.d("MainActivity:OnLoad", e.getMessage());
//        }

        return null;
    }

    @Override
    protected void onProgressUpdate(String... data) {

        _aa.add(data[0]);
        _pb.setProgress(_aa.getCount() * 10);
        //Toast toast = Toast.makeText(_context, "The file is being loaded", Toast.LENGTH_SHORT);
    }

    @Override
    protected void onPostExecute(Void result) {
        super.onPostExecute(result);
        _pb.setProgress(0);
        Toast toast = Toast.makeText(_context, "The file has been loaded", Toast.LENGTH_SHORT);
    }
}
