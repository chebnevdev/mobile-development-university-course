package com.chebnevdev.mobiledevelopmentcourse.task3

import androidx.appcompat.app.AppCompatActivity
import androidx.fragment.app.Fragment
import androidx.viewpager2.adapter.FragmentStateAdapter

class GridCollectionAdapter(activity: AppCompatActivity, private val layouts: List<Int>) :
    FragmentStateAdapter(activity) {

    override fun getItemCount() = layouts.size

    override fun createFragment(position: Int) = Fragment(layouts[position])
}