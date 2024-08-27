﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{ 
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do Titulo não pode ser maior de 50 caracteres")]
    public string? Genero { get; set; }
    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string? Diretor { get; set; }
    [Required]
    [Range(70, 220, ErrorMessage = "A duração do filme deve ser de 70 a 220 minutos")]
    public int? Duracao { get; set; }
}
