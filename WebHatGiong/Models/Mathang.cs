using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebHatGiong.Models;

[Table("MATHANG")]
public partial class Mathang
{
    [Key]
    [Column("MaMH")]
    public int MaMh { get; set; }

    [StringLength(100)]
    public string Ten { get; set; } = null!;

    public int? GiaGoc { get; set; }

    public int? GiaBan { get; set; }

    public short? SoLuong { get; set; }

    [StringLength(1000)]
    public string? MoTa { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? HinhAnh { get; set; }

    [Column("MaDM")]
    public int MaDm { get; set; }

    public int? LuotXem { get; set; }

    public int? LuotMua { get; set; }

    [StringLength(50)]
    public string? MuaVu { get; set; }

    [StringLength(20)]
    public string? TyLeNayMam { get; set; }

    public int? ThoiGianThuHoach { get; set; }

    [InverseProperty("MaMhNavigation")]
    public virtual ICollection<Cthoadon> Cthoadons { get; set; } = new List<Cthoadon>();

    [ForeignKey("MaDm")]
    [InverseProperty("Mathangs")]
    public virtual Danhmuc MaDmNavigation { get; set; } = null!;
}
