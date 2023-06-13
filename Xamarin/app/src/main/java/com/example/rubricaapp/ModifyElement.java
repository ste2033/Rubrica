package com.example.rubricaapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class ModifyElement extends AppCompatActivity {

    EditText noteInput;
    EditText nomeInput;
    EditText telefonoInput;
    EditText codiceInput;
    private String filePath = "./sdcard/rubrica.txt";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modify_elements);

        noteInput = findViewById(R.id.noteInput);
        nomeInput = findViewById(R.id.nomeInput);
        telefonoInput = findViewById(R.id.telefonoInput);
        codiceInput = findViewById(R.id.codiceInput);
    }

    public void annulla() {
        finish();
    }

    public void salvaElemento(){
        String textNote = noteInput.getText().toString();
        String textNome = nomeInput.getText().toString();
        String textTelefono = telefonoInput.getText().toString();
        String textCodice = codiceInput.getText().toString();

        //TODO: convert all data into jsonText
        //writetoFile();

        annulla();
    }

    public void cancellaElemento(){
        annulla();
    }


    public void writetoFile(String jsonText) {

        File file = new File(filePath);
        if (!file.exists()) try {
            file.createNewFile();
        } catch (IOException e1) {
            // TODO Auto-generated catch block
            e1.printStackTrace();
        }

        FileWriter fileWriter;
        try {
            //you can change second parametre true or false this is about append or clean and write
            fileWriter = new FileWriter(file, false);

            BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
            bufferedWriter.append(jsonText);

            bufferedWriter.close();

        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }

    }
}