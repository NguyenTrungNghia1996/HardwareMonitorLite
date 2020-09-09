String  ngayTrongTuan, thang, ngay, gio, phut, giay, nam;
int     hour, minute, sec;
void capNhatThoiGian() {
  time_t now = time(nullptr);
  String data = ctime(&now);    // Lưu chuỗi nhận được
  ngayTrongTuan  = data.substring(0, 3);
  String month          = data.substring(4, 7);
  ngay                  = data.substring(8, 10);            // Ngày để hiển thị
  gio                   = data.substring(11, 13);           // Giờ để hiển thị
  phut                  = data.substring(14, 16);           // Phút để hiển thị
  giay                  = data.substring(17, 19);           // Giây để hiển thị
  nam                   = data.substring(20, 24);           // Năm để hiển thị
  ngayTrongTuan.toUpperCase();
  ngay.trim();
  if (ngay.toInt() < 10) {
    ngay = "0" + ngay;
  }
  if (month == "Jan")  thang = "01";
  else if (month == "Feb")  thang = "02";
  else if (month == "Mar")  thang = "03";
  else if (month == "Apr")  thang = "04";
  else if (month == "May")  thang = "05";
  else if (month == "Jun")  thang = "06";
  else if (month == "Jul")  thang = "07";
  else if (month == "Aug")  thang = "08";
  else if (month == "Sep")  thang = "09";
  else if (month == "Oct")  thang = "10";
  else if (month == "Nov")  thang = "11";
  else if (month == "Dec")  thang = "12";
  hour    = gio.toInt();
  minute  = phut.toInt();
  sec     = giay.toInt();
}
void ngat() {
  sec++;
  if (sec == 60) {
    minute++;
    sec = 0;
  }
  if (minute == 60) {
    hour++;
    minute = 0;
  }
  if (hour == 24) {                             // Sau 1 ngày cập nhật thời gian 1 lần
    hour = 0;
    capNhatThoiGian();
  }
  if (WiFi.status() != WL_CONNECTED)
    WiFi.reconnect();
}
