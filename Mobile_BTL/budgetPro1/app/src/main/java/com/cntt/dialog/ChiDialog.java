package com.cntt.dialog;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.lifecycle.Observer;

import com.cntt.R;
import com.cntt.adapter.LoaiChiSpinnerAdapter;
import com.cntt.entity.Chi;
import com.cntt.entity.LoaiChi;
import com.cntt.ui.chi.KhoanChiFragment;
import com.cntt.ui.chi.KhoanChiViewModel;
import com.google.android.material.textfield.TextInputEditText;

import java.util.List;

public class ChiDialog {

    public KhoanChiViewModel mViewModel;
    public LayoutInflater mLayoutInflater;
    public AlertDialog mDialog;

    public TextInputEditText etIdChi;
    public TextInputEditText etNameChi;
    public TextInputEditText etAmountChi;
    public TextInputEditText etNoteChi;

    private Spinner spTypeChi;
    private TextView tvContent;
    private LoaiChiSpinnerAdapter adapter;
    private boolean checkMode; //xem là sửa hay là input


    public ChiDialog(Context context, KhoanChiFragment fragment, Chi ... chi) {
        mViewModel = fragment.getViewModel();
        mLayoutInflater = LayoutInflater.from(context);

        View view = mLayoutInflater.inflate(R.layout.chi_dialog,null);

        etIdChi = view.findViewById(R.id.edIdChi);
        etNameChi = view.findViewById(R.id.edNameChi);
        etAmountChi = view.findViewById(R.id.etAmountChi);
        etNoteChi = view.findViewById(R.id.etNoteChi);
        spTypeChi = view.findViewById(R.id.spTypeChi);


//      Sử lý khi size Loai Thu thay đổi -> spinner cũng thay đổi
        adapter = new LoaiChiSpinnerAdapter(fragment.getActivity());
        mViewModel.getLoaiChi().observe(fragment.getActivity(), new Observer<List<LoaiChi>>() {
            @Override
            public void onChanged(List<LoaiChi> loaiChis) {
                adapter.setList(loaiChis);
            }
        });
        spTypeChi.setAdapter(adapter);

        if (chi != null && chi.length > 0){
            etIdChi.setText("" + chi[0].cId);
            etNameChi.setText(chi[0].cName);
            etAmountChi.setText(""+chi[0].soTien);
            etNoteChi.setText(chi[0].note);
            checkMode = true;
        }else {
            checkMode = false;
        }
//        Sử lý khi người dùng click vào biểu tương add
        AlertDialog.Builder builder = new AlertDialog.Builder(context).setView(view).setNegativeButton("Đóng", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                mDialog.dismiss();
            }
        }).setPositiveButton("Lưu", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                Chi chi = new Chi();
                chi.cName = etNameChi.getText().toString();
                chi.lcId = ((LoaiChi) adapter.getItem(spTypeChi.getSelectedItemPosition())).lid;
                chi.soTien = Float.valueOf(etAmountChi.getText().toString());
                chi.note = etNoteChi.getText().toString();
//                Validate and add item in list
//                Trường hợp trùng nhau (Thiếu validate) và là số
                if (checkMode){
                    chi.cId = Integer.parseInt(etIdChi.getText().toString());
                    mViewModel.updateC(chi);
                    Toast.makeText(context,"Sửa thành công khoản chi",Toast.LENGTH_LONG).show();
                }else {
                    if(etNameChi.getText().toString().isEmpty() || etAmountChi.getText().toString().isEmpty()){
                        Toast.makeText(context,"Tên khoản chi hoặc số tiền rỗng",Toast.LENGTH_LONG).show();
                    }else {
                        mViewModel.insertC(chi);
                        Toast.makeText(context,"Loại chi đã được thêm",Toast.LENGTH_LONG).show();
                    }
                }
            }
        });
        mDialog = builder.create();
    }

    public void Show(){
        mDialog.show();
    }
}
