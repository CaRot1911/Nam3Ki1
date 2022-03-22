package com.cntt.dao;

import androidx.lifecycle.LiveData;
import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import com.cntt.entity.Chi;

import java.util.List;

@Dao
public interface ChiDao {

    @Query("SELECT * FROM Chi")
    public LiveData<List<Chi>> findAll();

    @Insert
    public void insertC(Chi chi);

    @Update
    public void updateC(Chi chi);

    @Delete
    public void deleteC(Chi Chi);
}
