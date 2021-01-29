package com.chebnevdev.mobiledevelopmentcourse

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.chebnevdev.mobiledevelopmentcourse.task1.Task1SLActivity
import kotlinx.android.synthetic.main.tasks_main_activity.*

class TasksMainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.tasks_main_activity)

        main_activity_tasks_recycler_view.adapter = TasksRecyclerViewAdapter(
            listOf(
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java),
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java),
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java),
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java),
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java),
                TaskItem("Task #1: StackLayout", Task1SLActivity::class.java)
            )
        ) {
            startActivity(Intent(this, it.activityClass))
        }

        main_activity_tasks_recycler_view.layoutManager = LinearLayoutManager(this)
    }
}