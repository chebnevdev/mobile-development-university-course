package com.chebnevdev.mobiledevelopmentcourse.task3

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.chebnevdev.mobiledevelopmentcourse.R
import kotlinx.android.synthetic.main.task_3_grid_activity.*

class Task3GridActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        setContentView(R.layout.task_3_grid_activity)

        gridPager.adapter = GridCollectionAdapter(
            this,
            listOf(R.layout.task_3_1_layout, R.layout.task_3_2_layout, R.layout.task_3_3_layout)
        )
    }
}