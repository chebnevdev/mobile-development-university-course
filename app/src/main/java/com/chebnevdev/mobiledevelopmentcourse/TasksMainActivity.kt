package com.chebnevdev.mobiledevelopmentcourse

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.appcompat.app.AppCompatDelegate
import androidx.recyclerview.widget.LinearLayoutManager
import com.chebnevdev.mobiledevelopmentcourse.task1.Task1SLActivity
import com.chebnevdev.mobiledevelopmentcourse.task2.Task2ButtonActivity
import com.chebnevdev.mobiledevelopmentcourse.task3.Task3GridActivity
import kotlinx.android.synthetic.main.tasks_main_activity.*

class TasksMainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO)
        setContentView(R.layout.tasks_main_activity)

        main_activity_tasks_recycler_view.adapter = TasksRecyclerViewAdapter(
            listOf(
                TaskItem("StackLayout", Task1SLActivity::class.java),
                TaskItem("Button", Task2ButtonActivity::class.java),
                TaskItem("Grid", Task3GridActivity::class.java),
                TaskItem("TabbedPage", AppCompatActivity::class.java),
                TaskItem("CheckBox", AppCompatActivity::class.java),
                TaskItem("RadioButton", AppCompatActivity::class.java),
                TaskItem("ContentView", AppCompatActivity::class.java),
                TaskItem("Images", AppCompatActivity::class.java),
                TaskItem("DatePicker", AppCompatActivity::class.java),
                TaskItem("Label & Expander", AppCompatActivity::class.java),
            )
        ) {
            startActivity(
                Intent(this, it.activityClass).putExtra("TITLE", it.name)
            )
        }

        main_activity_tasks_recycler_view.layoutManager = LinearLayoutManager(this)
    }
}