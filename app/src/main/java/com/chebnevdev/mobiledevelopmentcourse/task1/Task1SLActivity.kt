package com.chebnevdev.mobiledevelopmentcourse.task1

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.chebnevdev.mobiledevelopmentcourse.R

class Task1SLActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.task_1_sl_activity)

        supportActionBar?.title = intent.getStringExtra("TITLE")
    }
}