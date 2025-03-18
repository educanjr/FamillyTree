'use client';

import { useState, useEffect, useRef } from 'react';
import { ChevronDown, ChevronUp } from 'lucide-react';
import Input from './input/input';
import Card from './card/card';
import Option from './option/option';

import styles from './dropdown.module.css';
import { DropdownOption } from '@/Interfaces/DropdownOption';



interface DropdownSelectClientProps {
    options: DropdownOption[];
}

export default function DropdownSelect({ options }: DropdownSelectClientProps) {
    const [filteredOptions, setFilteredOptions] = useState<DropdownOption[]>(options);
    const [selected, setSelected] = useState<DropdownOption | null>(null);
    const [isOpen, setIsOpen] = useState<boolean>(false);
    const [search, setSearch] = useState<string>('');
    const dropdownRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        if (search && search.length > 2) {
            setFilteredOptions(
                options.filter((option) =>
                    option.label.toLowerCase().includes(search.toLowerCase())   
                )
            );
        }
    }, [search, options]);

    const handleSelect = (option: DropdownOption) => {
        setSelected(option);
        setIsOpen(false);
        setSearch('');
        console.log("Item selected")
    };

    const handleSearch = (target : string) => {
        if (!target || target.length === 0) {
            setSelected(null);
        }

        setSearch(target);
    }

    const getInputValue = () => {
        if ((!search || search.length < 0) && selected){
            return selected.label;
        }
        
        return search;
    }

    const handleClickOutside = (event: MouseEvent) => {
        if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
            handleOpenClose(false);
        }
    };

    const handleOpenClose = (status: boolean) => {
        if (!status) {
            setSearch('');    
        }

        setIsOpen(status);
    }

    useEffect(() => {
        document.addEventListener('mousedown', handleClickOutside);
        return () => {
            document.removeEventListener('mousedown', handleClickOutside);
        };
    }, []);

    return (
        <div className={styles['dropdown']} ref={dropdownRef}>
            <label className={styles['dropdown-label']}>
                Select a family from the list
            </label>
            <div className={styles['dropdown-input']} onClick={() => handleOpenClose(!isOpen)}>
                <Input
                    placeholder="Search..."
                    value={getInputValue()}
                    onChange={(e) => handleSearch(e.target.value)}
                    onClick={(e) => {
                        e.stopPropagation();
                        handleOpenClose(true);
                    }}
                />
                {isOpen ? <ChevronUp /> : <ChevronDown />}
            </div>
            {isOpen && (
                <Card>
                    {filteredOptions.length > 0 ? (
                        filteredOptions.map((option) => (
                            <Option
                                key={option.value}
                                isSelected={selected?.value === option.value}
                                onClick={() => handleSelect(option)}>
                                {option.label}
                            </Option>
                        ))
                    ) : (
                        <div className={styles['dropdown-no-options']}>No options found</div>
                    )}
                </Card>
            )}
        </div>
    );
}