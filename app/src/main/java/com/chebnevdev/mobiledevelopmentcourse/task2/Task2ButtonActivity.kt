package com.chebnevdev.mobiledevelopmentcourse.task2

import android.os.Bundle
import android.os.Handler
import android.os.Message
import android.view.MotionEvent
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import com.chebnevdev.mobiledevelopmentcourse.R
import kotlinx.android.synthetic.main.task_2_button_activity.*
import org.jetbrains.anko.toast
import java.lang.ref.WeakReference
import java.util.*
import kotlin.concurrent.schedule

class Task2ButtonActivity : AppCompatActivity() {

    private val rotationHandler = RotationHandler(this)
    private var rotationTask: TimerTask? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        setContentView(R.layout.task_2_button_activity)

        rotationButton.setOnTouchListener { button, motionEvent ->
            when (motionEvent.action) {
                MotionEvent.ACTION_DOWN -> {
                    rotationTask = Timer(true).schedule(0, 16) {
                        rotationHandler.sendEmptyMessage(16)
                    }
                    return@setOnTouchListener true
                }
                MotionEvent.ACTION_UP -> {
                    button.performClick()
                    rotationTask?.cancel()
                    return@setOnTouchListener true
                }
            }
            false
        }
    }

    private class RotationHandler(activity: Task2ButtonActivity) : Handler() {

        private val activity = WeakReference(activity)

        override fun handleMessage(msg: Message) {
            activity.get()?.rotationText?.apply {
                rotation += msg.what.toFloat() * 360 / 1000
            }
        }
    }
}