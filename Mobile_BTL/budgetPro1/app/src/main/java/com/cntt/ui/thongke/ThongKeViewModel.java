package com.cntt.ui.thongke;

import android.app.Application;

import androidx.annotation.NonNull;
import androidx.lifecycle.AndroidViewModel;
import androidx.lifecycle.LiveData;

import com.cntt.entity.ThongKeLoaiThu;
import com.cntt.repository.ThuRepository;

import java.util.List;

public class ThongKeViewModel extends AndroidViewModel {
    private ThuRepository repository;
    private LiveData<Float> mTongThu;
    private LiveData<List<ThongKeLoaiThu>> mLis;

    public ThongKeViewModel(@NonNull Application application) {
        super(application);

        repository = new ThuRepository(application);
        mTongThu = repository.TongThu();
        mLis = repository.sumByType();
    }

    public LiveData<Float> getTongThu() {
        return mTongThu;
    }

    public LiveData<List<ThongKeLoaiThu>> getThongKeLoaiThu(){
        return mLis;
    }
}
