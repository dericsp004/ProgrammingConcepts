package com.plummer.deric.teach_06;

import android.content.Context;
import android.os.AsyncTask;
import android.util.Log;
import android.widget.ProgressBar;
import android.widget.Toast;

import java.io.FileOutputStream;


/**
 * Created by Deric on 5/24/17.
 */

public class CreateFileTask extends AsyncTask<Void, Integer, Void> {

    public String _fileName;
    Context _context;
    ProgressBar _pb;

    public CreateFileTask(Context context, String fileName, ProgressBar pb){
        _fileName = fileName;
        _context = context;
        _pb = pb;
    }

    protected void onPreExecute () {
        _pb.setProgress(0);
    }

    @Override
    protected Void doInBackground(Void... params) {
        try
        {
            FileOutputStream outputStream = _context.openFileOutput(_fileName, Context.MODE_PRIVATE);
            for (int i = 1; i <= 10; i++) {
                String line = String.format("%d\n", i);
                outputStream.write(line.getBytes());
                Thread.sleep(250);
                publishProgress(i);
            }
        }
        catch (Exception e) {
            Log.d("CreateFileTask: ", e.getMessage());
        }

        return null;
    }

    @Override
    protected void onProgressUpdate(Integer... data) {
        _pb.setProgress(data[0] * 10);
    }

    @Override
    protected void onPostExecute(Void result) {
        super.onPostExecute(result);
        _pb.setProgress(0);
        Toast toast = Toast.makeText(_context, "The file has been created.", Toast.LENGTH_SHORT);
        toast.show();

    }
}
