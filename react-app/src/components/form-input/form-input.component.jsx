import React from 'react';
import './form-input.styles.css';

const FormInput = ({placeHolder, className}) =>(
    <div class="input">
        <input type='text' className='search-input' placeholder={placeHolder} />
    </div>
)

export default FormInput;