package com.cntt.entity;

import androidx.room.ColumnInfo;
import androidx.room.Entity;
import androidx.room.PrimaryKey;

@Entity
public class Chi {

    @PrimaryKey(autoGenerate = true)
    public int cId;

    @ColumnInfo(name = "LoaiChiID")
    public int lcId;

    @ColumnInfo(name = "TenKhoanThu")
    public String cName;

    @ColumnInfo(name = "SoTien")
    public Float soTien;

    @ColumnInfo(name = "GhiChu")
    public String note;

}
