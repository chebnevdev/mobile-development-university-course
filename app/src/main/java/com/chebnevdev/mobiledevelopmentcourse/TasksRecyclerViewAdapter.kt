package com.chebnevdev.mobiledevelopmentcourse

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.RecyclerView

class TasksRecyclerViewAdapter(
    private val tasks: List<TaskItem>,
    private val clickListener: OnItemClickListener
) : RecyclerView.Adapter<TasksRecyclerViewAdapter.TaskViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): TaskViewHolder {
        return TaskViewHolder(
            LayoutInflater
                .from(parent.context)
                .inflate(R.layout.task_item_layout, parent, false)
        )
    }

    override fun onBindViewHolder(holder: TaskViewHolder, position: Int) {
        holder.bind(tasks[position], clickListener)
    }

    override fun getItemCount() = tasks.size

    class TaskViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {

        private val name: TextView = itemView.findViewById(R.id.task_item_text_view)

        fun bind(taskItem: TaskItem, listener: OnItemClickListener) {
            name.text = taskItem.name
            name.setOnClickListener {
                listener.onItemClick(taskItem)
            }
        }
    }

    fun interface OnItemClickListener {
        fun onItemClick(taskItem: TaskItem)
    }
}

data class TaskItem(val name: String, val activityClass: Class<out AppCompatActivity>)

